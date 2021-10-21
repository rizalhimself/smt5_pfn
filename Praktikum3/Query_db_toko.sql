CREATE DATABASE dbAppToko
ON PRIMARY
(
	name='toko_dat',
	filename='/var/opt/mssql/data/praktikum3_app_toko.mdf',
	maxsize=UNLIMITED,
	filegrowth=10MB
)

LOG ON
(
	name='toko_log',
	filename='/var/opt/mssql/data/praktikum3_app_toko.ldf',
	maxsize=UNLIMITED,
	filegrowth=10MB
)

--Membuat Tabel Barang
CREATE TABLE barang
(
	kode_brg char(5) not null PRIMARY KEY CHECK(left(kode_brg, 1)='B' 
	and ISNUMERIC(right(kode_brg, 4))=1),
	nama_brg varchar(50) not null,
	diskon int not null,
	harga_jual money not null,
	stok_gudang int not null,
	stok_rak int not null,
	rusak int not null,
	satuan varchar(10) not null
)

-- membuat tabel supplier
CREATE TABLE supplier
(
	kode_supp char(50) not null PRIMARY KEY CHECK (left(kode_supp,1)='5' 
	and ISNUMERIC(right(kode_supp,4))=1),
	nama_instansi varchar(25) not null,
	nama_manager varchar (25) not null,
	alamat varchar(50) not null,
	no_telp int not null,
	kontak_person int,
	no_fax int,
	email varchar(25),
	website varchar (25)
)

-- membuat tabel karyawan
CREATE TABLE karyawan
(
	nik char(10) not null PRIMARY KEY CHECK(isnumeric(left(nik,4))=1 
	and substring(nik,5,1)='.'
	and isnumeric(left(nik,2))=1
	and substring(nik,8,1)='.'
	and isnumeric(right(nik,3))=1),
	nama varchar(30) not null,
	alamat varchar(30) not null,
	kota varchar(30) not null,
	tempat_lahir varchar (15) not null,
	tgl_lahir datetime not null,
	agama varchar (10) default 'Islam',
	jk char(1) not null check(jk in('L','P')),
	status_menikah varchar(50) not null,
	tanggungan int not null,
	pendidikan varchar(30) not null,
	no_telp int not null
)

--membuat table pembelian
create table pembelian
(
	kode_beli varchar(8) not null primary key,
	tgl_beli datetime,
	kode_supp char(50) not null foreign key
		references supplier(kode_supp) 
		on update no action on delete no action,
	kode_brg char(5) not null foreign key
		references barang(kode_brg)
		on update no action on delete no action,
	jml_beli float(8) not null,
	harga_beli float(8) not null
)

--membuat tabel penjualan
create table penjualan
(
	kode_transaksi varchar(10) not null,
	no_jual float(8) not null,
	tgl_jual datetime not null,
	kode_brg char(5) not null foreign key
		references barang(kode_brg)
		on update no action on delete no action,
	jml_jual float(8) not null,
	jml_bayar varchar(100) not null,
	nik char(10) not null foreign key
		references karyawan(nik) 
		on update no action on delete no action
)

-- membuat tabel login
create table login_sistem
(
	nama_pengguna varchar(25) not null primary key,
	kata_sandi varchar(25) not null,
	hak_akses varchar(25) not null,
	nik char(10) not null foreign key
		references karyawan(nik)
		on update no action on delete no action
)

