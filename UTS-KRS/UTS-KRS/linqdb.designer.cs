﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UTS_KRS
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbAppKrs")]
	public partial class linqdbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertkr(kr instance);
    partial void Updatekr(kr instance);
    partial void Deletekr(kr instance);
    partial void Insertmahasiswa(mahasiswa instance);
    partial void Updatemahasiswa(mahasiswa instance);
    partial void Deletemahasiswa(mahasiswa instance);
    partial void Insertmakul(makul instance);
    partial void Updatemakul(makul instance);
    partial void Deletemakul(makul instance);
    #endregion
		
		public linqdbDataContext() : 
				base(global::UTS_KRS.Properties.Settings.Default.dbAppKrsConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public linqdbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqdbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqdbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqdbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<kr> krs
		{
			get
			{
				return this.GetTable<kr>();
			}
		}
		
		public System.Data.Linq.Table<mahasiswa> mahasiswas
		{
			get
			{
				return this.GetTable<mahasiswa>();
			}
		}
		
		public System.Data.Linq.Table<makul> makuls
		{
			get
			{
				return this.GetTable<makul>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.krs")]
	public partial class kr : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idKrs;
		
		private int _nim;
		
		private int _kdmakul;
		
		private string _status;
		
		private EntityRef<mahasiswa> _mahasiswa;
		
		private EntityRef<makul> _makul;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidKrsChanging(int value);
    partial void OnidKrsChanged();
    partial void OnnimChanging(int value);
    partial void OnnimChanged();
    partial void OnkdmakulChanging(int value);
    partial void OnkdmakulChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public kr()
		{
			this._mahasiswa = default(EntityRef<mahasiswa>);
			this._makul = default(EntityRef<makul>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idKrs", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idKrs
		{
			get
			{
				return this._idKrs;
			}
			set
			{
				if ((this._idKrs != value))
				{
					this.OnidKrsChanging(value);
					this.SendPropertyChanging();
					this._idKrs = value;
					this.SendPropertyChanged("idKrs");
					this.OnidKrsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nim", DbType="Int NOT NULL")]
		public int nim
		{
			get
			{
				return this._nim;
			}
			set
			{
				if ((this._nim != value))
				{
					if (this._mahasiswa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnnimChanging(value);
					this.SendPropertyChanging();
					this._nim = value;
					this.SendPropertyChanged("nim");
					this.OnnimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kdmakul", DbType="Int NOT NULL")]
		public int kdmakul
		{
			get
			{
				return this._kdmakul;
			}
			set
			{
				if ((this._kdmakul != value))
				{
					if (this._makul.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnkdmakulChanging(value);
					this.SendPropertyChanging();
					this._kdmakul = value;
					this.SendPropertyChanged("kdmakul");
					this.OnkdmakulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(20)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mahasiswa_kr", Storage="_mahasiswa", ThisKey="nim", OtherKey="nim", IsForeignKey=true)]
		public mahasiswa mahasiswa
		{
			get
			{
				return this._mahasiswa.Entity;
			}
			set
			{
				mahasiswa previousValue = this._mahasiswa.Entity;
				if (((previousValue != value) 
							|| (this._mahasiswa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._mahasiswa.Entity = null;
						previousValue.krs.Remove(this);
					}
					this._mahasiswa.Entity = value;
					if ((value != null))
					{
						value.krs.Add(this);
						this._nim = value.nim;
					}
					else
					{
						this._nim = default(int);
					}
					this.SendPropertyChanged("mahasiswa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="makul_kr", Storage="_makul", ThisKey="kdmakul", OtherKey="kdmakul", IsForeignKey=true)]
		public makul makul
		{
			get
			{
				return this._makul.Entity;
			}
			set
			{
				makul previousValue = this._makul.Entity;
				if (((previousValue != value) 
							|| (this._makul.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._makul.Entity = null;
						previousValue.krs.Remove(this);
					}
					this._makul.Entity = value;
					if ((value != null))
					{
						value.krs.Add(this);
						this._kdmakul = value.kdmakul;
					}
					else
					{
						this._kdmakul = default(int);
					}
					this.SendPropertyChanged("makul");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.mahasiswa")]
	public partial class mahasiswa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _nim;
		
		private string _namaMahasiswa;
		
		private string _prodi;
		
		private string _dosbing;
		
		private System.Nullable<int> _angkatan;
		
		private string _status;
		
		private EntitySet<kr> _krs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnimChanging(int value);
    partial void OnnimChanged();
    partial void OnnamaMahasiswaChanging(string value);
    partial void OnnamaMahasiswaChanged();
    partial void OnprodiChanging(string value);
    partial void OnprodiChanged();
    partial void OndosbingChanging(string value);
    partial void OndosbingChanged();
    partial void OnangkatanChanging(System.Nullable<int> value);
    partial void OnangkatanChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public mahasiswa()
		{
			this._krs = new EntitySet<kr>(new Action<kr>(this.attach_krs), new Action<kr>(this.detach_krs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nim", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int nim
		{
			get
			{
				return this._nim;
			}
			set
			{
				if ((this._nim != value))
				{
					this.OnnimChanging(value);
					this.SendPropertyChanging();
					this._nim = value;
					this.SendPropertyChanged("nim");
					this.OnnimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namaMahasiswa", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string namaMahasiswa
		{
			get
			{
				return this._namaMahasiswa;
			}
			set
			{
				if ((this._namaMahasiswa != value))
				{
					this.OnnamaMahasiswaChanging(value);
					this.SendPropertyChanging();
					this._namaMahasiswa = value;
					this.SendPropertyChanged("namaMahasiswa");
					this.OnnamaMahasiswaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prodi", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string prodi
		{
			get
			{
				return this._prodi;
			}
			set
			{
				if ((this._prodi != value))
				{
					this.OnprodiChanging(value);
					this.SendPropertyChanging();
					this._prodi = value;
					this.SendPropertyChanged("prodi");
					this.OnprodiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dosbing", DbType="VarChar(50)")]
		public string dosbing
		{
			get
			{
				return this._dosbing;
			}
			set
			{
				if ((this._dosbing != value))
				{
					this.OndosbingChanging(value);
					this.SendPropertyChanging();
					this._dosbing = value;
					this.SendPropertyChanged("dosbing");
					this.OndosbingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_angkatan", DbType="Int")]
		public System.Nullable<int> angkatan
		{
			get
			{
				return this._angkatan;
			}
			set
			{
				if ((this._angkatan != value))
				{
					this.OnangkatanChanging(value);
					this.SendPropertyChanging();
					this._angkatan = value;
					this.SendPropertyChanged("angkatan");
					this.OnangkatanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(20)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="mahasiswa_kr", Storage="_krs", ThisKey="nim", OtherKey="nim")]
		public EntitySet<kr> krs
		{
			get
			{
				return this._krs;
			}
			set
			{
				this._krs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_krs(kr entity)
		{
			this.SendPropertyChanging();
			entity.mahasiswa = this;
		}
		
		private void detach_krs(kr entity)
		{
			this.SendPropertyChanging();
			entity.mahasiswa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.makul")]
	public partial class makul : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _kdmakul;
		
		private string _nmMakul;
		
		private int _semester;
		
		private int _bobotsks;
		
		private string _dosenpengampu;
		
		private EntitySet<kr> _krs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnkdmakulChanging(int value);
    partial void OnkdmakulChanged();
    partial void OnnmMakulChanging(string value);
    partial void OnnmMakulChanged();
    partial void OnsemesterChanging(int value);
    partial void OnsemesterChanged();
    partial void OnbobotsksChanging(int value);
    partial void OnbobotsksChanged();
    partial void OndosenpengampuChanging(string value);
    partial void OndosenpengampuChanged();
    #endregion
		
		public makul()
		{
			this._krs = new EntitySet<kr>(new Action<kr>(this.attach_krs), new Action<kr>(this.detach_krs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kdmakul", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int kdmakul
		{
			get
			{
				return this._kdmakul;
			}
			set
			{
				if ((this._kdmakul != value))
				{
					this.OnkdmakulChanging(value);
					this.SendPropertyChanging();
					this._kdmakul = value;
					this.SendPropertyChanged("kdmakul");
					this.OnkdmakulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nmMakul", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nmMakul
		{
			get
			{
				return this._nmMakul;
			}
			set
			{
				if ((this._nmMakul != value))
				{
					this.OnnmMakulChanging(value);
					this.SendPropertyChanging();
					this._nmMakul = value;
					this.SendPropertyChanged("nmMakul");
					this.OnnmMakulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_semester", DbType="Int NOT NULL")]
		public int semester
		{
			get
			{
				return this._semester;
			}
			set
			{
				if ((this._semester != value))
				{
					this.OnsemesterChanging(value);
					this.SendPropertyChanging();
					this._semester = value;
					this.SendPropertyChanged("semester");
					this.OnsemesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bobotsks", DbType="Int NOT NULL")]
		public int bobotsks
		{
			get
			{
				return this._bobotsks;
			}
			set
			{
				if ((this._bobotsks != value))
				{
					this.OnbobotsksChanging(value);
					this.SendPropertyChanging();
					this._bobotsks = value;
					this.SendPropertyChanged("bobotsks");
					this.OnbobotsksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dosenpengampu", DbType="VarChar(50)")]
		public string dosenpengampu
		{
			get
			{
				return this._dosenpengampu;
			}
			set
			{
				if ((this._dosenpengampu != value))
				{
					this.OndosenpengampuChanging(value);
					this.SendPropertyChanging();
					this._dosenpengampu = value;
					this.SendPropertyChanged("dosenpengampu");
					this.OndosenpengampuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="makul_kr", Storage="_krs", ThisKey="kdmakul", OtherKey="kdmakul")]
		public EntitySet<kr> krs
		{
			get
			{
				return this._krs;
			}
			set
			{
				this._krs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_krs(kr entity)
		{
			this.SendPropertyChanging();
			entity.makul = this;
		}
		
		private void detach_krs(kr entity)
		{
			this.SendPropertyChanging();
			entity.makul = null;
		}
	}
}
#pragma warning restore 1591
