﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.1
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq_to_SQL4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Northwind")]
	public partial class NorthwindDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 擴充性方法定義
    partial void OnCreated();
    partial void Insert產品資料(產品資料 instance);
    partial void Update產品資料(產品資料 instance);
    partial void Delete產品資料(產品資料 instance);
    partial void Insert產品類別(產品類別 instance);
    partial void Update產品類別(產品類別 instance);
    partial void Delete產品類別(產品類別 instance);
    #endregion
		
		public NorthwindDataContext() : 
				base(global::Linq_to_SQL4.Properties.Settings.Default.NorthwindConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<產品資料> 產品資料
		{
			get
			{
				return this.GetTable<產品資料>();
			}
		}
		
		public System.Data.Linq.Table<產品類別> 產品類別
		{
			get
			{
				return this.GetTable<產品類別>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.產品資料")]
	public partial class 產品資料 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _產品編號;
		
		private string _產品;
		
		private System.Nullable<int> _供應商編號;
		
		private System.Nullable<int> _類別編號;
		
		private string _單位數量;
		
		private System.Nullable<decimal> _單價;
		
		private System.Nullable<short> _庫存量;
		
		private System.Nullable<short> _已訂購量;
		
		private System.Nullable<short> _安全存量;
		
		private bool _不再銷售;
		
		private EntityRef<產品類別> _產品類別;
		
    #region 擴充性方法定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void On產品編號Changing(int value);
    partial void On產品編號Changed();
    partial void On產品Changing(string value);
    partial void On產品Changed();
    partial void On供應商編號Changing(System.Nullable<int> value);
    partial void On供應商編號Changed();
    partial void On類別編號Changing(System.Nullable<int> value);
    partial void On類別編號Changed();
    partial void On單位數量Changing(string value);
    partial void On單位數量Changed();
    partial void On單價Changing(System.Nullable<decimal> value);
    partial void On單價Changed();
    partial void On庫存量Changing(System.Nullable<short> value);
    partial void On庫存量Changed();
    partial void On已訂購量Changing(System.Nullable<short> value);
    partial void On已訂購量Changed();
    partial void On安全存量Changing(System.Nullable<short> value);
    partial void On安全存量Changed();
    partial void On不再銷售Changing(bool value);
    partial void On不再銷售Changed();
    #endregion
		
		public 產品資料()
		{
			this._產品類別 = default(EntityRef<產品類別>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_產品編號", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int 產品編號
		{
			get
			{
				return this._產品編號;
			}
			set
			{
				if ((this._產品編號 != value))
				{
					this.On產品編號Changing(value);
					this.SendPropertyChanging();
					this._產品編號 = value;
					this.SendPropertyChanged("產品編號");
					this.On產品編號Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_產品", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string 產品
		{
			get
			{
				return this._產品;
			}
			set
			{
				if ((this._產品 != value))
				{
					this.On產品Changing(value);
					this.SendPropertyChanging();
					this._產品 = value;
					this.SendPropertyChanged("產品");
					this.On產品Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_供應商編號", DbType="Int")]
		public System.Nullable<int> 供應商編號
		{
			get
			{
				return this._供應商編號;
			}
			set
			{
				if ((this._供應商編號 != value))
				{
					this.On供應商編號Changing(value);
					this.SendPropertyChanging();
					this._供應商編號 = value;
					this.SendPropertyChanged("供應商編號");
					this.On供應商編號Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_類別編號", DbType="Int")]
		public System.Nullable<int> 類別編號
		{
			get
			{
				return this._類別編號;
			}
			set
			{
				if ((this._類別編號 != value))
				{
					if (this._產品類別.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.On類別編號Changing(value);
					this.SendPropertyChanging();
					this._類別編號 = value;
					this.SendPropertyChanged("類別編號");
					this.On類別編號Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_單位數量", DbType="NVarChar(20)")]
		public string 單位數量
		{
			get
			{
				return this._單位數量;
			}
			set
			{
				if ((this._單位數量 != value))
				{
					this.On單位數量Changing(value);
					this.SendPropertyChanging();
					this._單位數量 = value;
					this.SendPropertyChanged("單位數量");
					this.On單位數量Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_單價", DbType="Money")]
		public System.Nullable<decimal> 單價
		{
			get
			{
				return this._單價;
			}
			set
			{
				if ((this._單價 != value))
				{
					this.On單價Changing(value);
					this.SendPropertyChanging();
					this._單價 = value;
					this.SendPropertyChanged("單價");
					this.On單價Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_庫存量", DbType="SmallInt")]
		public System.Nullable<short> 庫存量
		{
			get
			{
				return this._庫存量;
			}
			set
			{
				if ((this._庫存量 != value))
				{
					this.On庫存量Changing(value);
					this.SendPropertyChanging();
					this._庫存量 = value;
					this.SendPropertyChanged("庫存量");
					this.On庫存量Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_已訂購量", DbType="SmallInt")]
		public System.Nullable<short> 已訂購量
		{
			get
			{
				return this._已訂購量;
			}
			set
			{
				if ((this._已訂購量 != value))
				{
					this.On已訂購量Changing(value);
					this.SendPropertyChanging();
					this._已訂購量 = value;
					this.SendPropertyChanged("已訂購量");
					this.On已訂購量Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_安全存量", DbType="SmallInt")]
		public System.Nullable<short> 安全存量
		{
			get
			{
				return this._安全存量;
			}
			set
			{
				if ((this._安全存量 != value))
				{
					this.On安全存量Changing(value);
					this.SendPropertyChanging();
					this._安全存量 = value;
					this.SendPropertyChanged("安全存量");
					this.On安全存量Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_不再銷售", DbType="Bit NOT NULL")]
		public bool 不再銷售
		{
			get
			{
				return this._不再銷售;
			}
			set
			{
				if ((this._不再銷售 != value))
				{
					this.On不再銷售Changing(value);
					this.SendPropertyChanging();
					this._不再銷售 = value;
					this.SendPropertyChanged("不再銷售");
					this.On不再銷售Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="產品類別_產品資料", Storage="_產品類別", ThisKey="類別編號", OtherKey="類別編號", IsForeignKey=true)]
		public 產品類別 產品類別
		{
			get
			{
				return this._產品類別.Entity;
			}
			set
			{
				產品類別 previousValue = this._產品類別.Entity;
				if (((previousValue != value) 
							|| (this._產品類別.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._產品類別.Entity = null;
						previousValue.產品資料.Remove(this);
					}
					this._產品類別.Entity = value;
					if ((value != null))
					{
						value.產品資料.Add(this);
						this._類別編號 = value.類別編號;
					}
					else
					{
						this._類別編號 = default(Nullable<int>);
					}
					this.SendPropertyChanged("產品類別");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.產品類別")]
	public partial class 產品類別 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _類別編號;
		
		private string _類別名稱;
		
		private string _說明;
		
		private System.Data.Linq.Binary _圖片;
		
		private EntitySet<產品資料> _產品資料;
		
    #region 擴充性方法定義
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void On類別編號Changing(int value);
    partial void On類別編號Changed();
    partial void On類別名稱Changing(string value);
    partial void On類別名稱Changed();
    partial void On說明Changing(string value);
    partial void On說明Changed();
    partial void On圖片Changing(System.Data.Linq.Binary value);
    partial void On圖片Changed();
    #endregion
		
		public 產品類別()
		{
			this._產品資料 = new EntitySet<產品資料>(new Action<產品資料>(this.attach_產品資料), new Action<產品資料>(this.detach_產品資料));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_類別編號", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int 類別編號
		{
			get
			{
				return this._類別編號;
			}
			set
			{
				if ((this._類別編號 != value))
				{
					this.On類別編號Changing(value);
					this.SendPropertyChanging();
					this._類別編號 = value;
					this.SendPropertyChanged("類別編號");
					this.On類別編號Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_類別名稱", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string 類別名稱
		{
			get
			{
				return this._類別名稱;
			}
			set
			{
				if ((this._類別名稱 != value))
				{
					this.On類別名稱Changing(value);
					this.SendPropertyChanging();
					this._類別名稱 = value;
					this.SendPropertyChanged("類別名稱");
					this.On類別名稱Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_說明", DbType="NVarChar(MAX)")]
		public string 說明
		{
			get
			{
				return this._說明;
			}
			set
			{
				if ((this._說明 != value))
				{
					this.On說明Changing(value);
					this.SendPropertyChanging();
					this._說明 = value;
					this.SendPropertyChanged("說明");
					this.On說明Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_圖片", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary 圖片
		{
			get
			{
				return this._圖片;
			}
			set
			{
				if ((this._圖片 != value))
				{
					this.On圖片Changing(value);
					this.SendPropertyChanging();
					this._圖片 = value;
					this.SendPropertyChanged("圖片");
					this.On圖片Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="產品類別_產品資料", Storage="_產品資料", ThisKey="類別編號", OtherKey="類別編號")]
		public EntitySet<產品資料> 產品資料
		{
			get
			{
				return this._產品資料;
			}
			set
			{
				this._產品資料.Assign(value);
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
		
		private void attach_產品資料(產品資料 entity)
		{
			this.SendPropertyChanging();
			entity.產品類別 = this;
		}
		
		private void detach_產品資料(產品資料 entity)
		{
			this.SendPropertyChanging();
			entity.產品類別 = null;
		}
	}
}
#pragma warning restore 1591