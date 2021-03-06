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

namespace AstroPhoto.Catalog.LoaderUi
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Astrophoto")]
	public partial class AstroPhotoDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    partial void InsertImageType(ImageType instance);
    partial void UpdateImageType(ImageType instance);
    partial void DeleteImageType(ImageType instance);
    partial void InsertProject(Project instance);
    partial void UpdateProject(Project instance);
    partial void DeleteProject(Project instance);
    partial void InsertSession(Session instance);
    partial void UpdateSession(Session instance);
    partial void DeleteSession(Session instance);
    #endregion
		
		public AstroPhotoDataDataContext() : 
				base(global::AstroPhoto.Catalog.LoaderUi.Properties.Settings.Default.AstrophotoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AstroPhotoDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AstroPhotoDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AstroPhotoDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AstroPhotoDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<ImageType> ImageTypes
		{
			get
			{
				return this.GetTable<ImageType>();
			}
		}
		
		public System.Data.Linq.Table<Project> Projects
		{
			get
			{
				return this.GetTable<Project>();
			}
		}
		
		public System.Data.Linq.Table<Session> Sessions
		{
			get
			{
				return this.GetTable<Session>();
			}
		}
		
		public System.Data.Linq.Table<ImagesView> ImagesViews
		{
			get
			{
				return this.GetTable<ImagesView>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Images")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ImageId;
		
		private int _ProjectId;
		
		private int _SessionId;
		
		private string _FilePath;
		
		private int _ImageTypeId;
		
		private System.DateTime _DateAdded;
		
		private EntityRef<ImageType> _ImageType;
		
		private EntityRef<Project> _Project;
		
		private EntityRef<Session> _Session;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnImageIdChanging(int value);
    partial void OnImageIdChanged();
    partial void OnProjectIdChanging(int value);
    partial void OnProjectIdChanged();
    partial void OnSessionIdChanging(int value);
    partial void OnSessionIdChanged();
    partial void OnFilePathChanging(string value);
    partial void OnFilePathChanged();
    partial void OnImageTypeIdChanging(int value);
    partial void OnImageTypeIdChanged();
    partial void OnDateAddedChanging(System.DateTime value);
    partial void OnDateAddedChanged();
    #endregion
		
		public Image()
		{
			this._ImageType = default(EntityRef<ImageType>);
			this._Project = default(EntityRef<Project>);
			this._Session = default(EntityRef<Session>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ImageId
		{
			get
			{
				return this._ImageId;
			}
			set
			{
				if ((this._ImageId != value))
				{
					this.OnImageIdChanging(value);
					this.SendPropertyChanging();
					this._ImageId = value;
					this.SendPropertyChanged("ImageId");
					this.OnImageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectId", DbType="Int NOT NULL")]
		public int ProjectId
		{
			get
			{
				return this._ProjectId;
			}
			set
			{
				if ((this._ProjectId != value))
				{
					if (this._Project.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProjectIdChanging(value);
					this.SendPropertyChanging();
					this._ProjectId = value;
					this.SendPropertyChanged("ProjectId");
					this.OnProjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionId", DbType="Int NOT NULL")]
		public int SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				if ((this._SessionId != value))
				{
					if (this._Session.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSessionIdChanging(value);
					this.SendPropertyChanging();
					this._SessionId = value;
					this.SendPropertyChanged("SessionId");
					this.OnSessionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilePath", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FilePath
		{
			get
			{
				return this._FilePath;
			}
			set
			{
				if ((this._FilePath != value))
				{
					this.OnFilePathChanging(value);
					this.SendPropertyChanging();
					this._FilePath = value;
					this.SendPropertyChanged("FilePath");
					this.OnFilePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageTypeId", DbType="Int NOT NULL")]
		public int ImageTypeId
		{
			get
			{
				return this._ImageTypeId;
			}
			set
			{
				if ((this._ImageTypeId != value))
				{
					if (this._ImageType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnImageTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ImageTypeId = value;
					this.SendPropertyChanged("ImageTypeId");
					this.OnImageTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAdded", DbType="DateTime NOT NULL")]
		public System.DateTime DateAdded
		{
			get
			{
				return this._DateAdded;
			}
			set
			{
				if ((this._DateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._DateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ImageType_Image", Storage="_ImageType", ThisKey="ImageTypeId", OtherKey="ImageTypeId", IsForeignKey=true)]
		public ImageType ImageType
		{
			get
			{
				return this._ImageType.Entity;
			}
			set
			{
				ImageType previousValue = this._ImageType.Entity;
				if (((previousValue != value) 
							|| (this._ImageType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ImageType.Entity = null;
						previousValue.Images.Remove(this);
					}
					this._ImageType.Entity = value;
					if ((value != null))
					{
						value.Images.Add(this);
						this._ImageTypeId = value.ImageTypeId;
					}
					else
					{
						this._ImageTypeId = default(int);
					}
					this.SendPropertyChanged("ImageType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Image", Storage="_Project", ThisKey="ProjectId", OtherKey="ProjectId", IsForeignKey=true)]
		public Project Project
		{
			get
			{
				return this._Project.Entity;
			}
			set
			{
				Project previousValue = this._Project.Entity;
				if (((previousValue != value) 
							|| (this._Project.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Project.Entity = null;
						previousValue.Images.Remove(this);
					}
					this._Project.Entity = value;
					if ((value != null))
					{
						value.Images.Add(this);
						this._ProjectId = value.ProjectId;
					}
					else
					{
						this._ProjectId = default(int);
					}
					this.SendPropertyChanged("Project");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Session_Image", Storage="_Session", ThisKey="SessionId", OtherKey="SessionId", IsForeignKey=true)]
		public Session Session
		{
			get
			{
				return this._Session.Entity;
			}
			set
			{
				Session previousValue = this._Session.Entity;
				if (((previousValue != value) 
							|| (this._Session.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Session.Entity = null;
						previousValue.Images.Remove(this);
					}
					this._Session.Entity = value;
					if ((value != null))
					{
						value.Images.Add(this);
						this._SessionId = value.SessionId;
					}
					else
					{
						this._SessionId = default(int);
					}
					this.SendPropertyChanged("Session");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ImageTypes")]
	public partial class ImageType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ImageTypeId;
		
		private string _Name;
		
		private string _LookupTag;
		
		private EntitySet<Image> _Images;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnImageTypeIdChanging(int value);
    partial void OnImageTypeIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLookupTagChanging(string value);
    partial void OnLookupTagChanged();
    #endregion
		
		public ImageType()
		{
			this._Images = new EntitySet<Image>(new Action<Image>(this.attach_Images), new Action<Image>(this.detach_Images));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageTypeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ImageTypeId
		{
			get
			{
				return this._ImageTypeId;
			}
			set
			{
				if ((this._ImageTypeId != value))
				{
					this.OnImageTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ImageTypeId = value;
					this.SendPropertyChanged("ImageTypeId");
					this.OnImageTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LookupTag", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string LookupTag
		{
			get
			{
				return this._LookupTag;
			}
			set
			{
				if ((this._LookupTag != value))
				{
					this.OnLookupTagChanging(value);
					this.SendPropertyChanging();
					this._LookupTag = value;
					this.SendPropertyChanged("LookupTag");
					this.OnLookupTagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ImageType_Image", Storage="_Images", ThisKey="ImageTypeId", OtherKey="ImageTypeId")]
		public EntitySet<Image> Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				this._Images.Assign(value);
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
		
		private void attach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.ImageType = this;
		}
		
		private void detach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.ImageType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Projects")]
	public partial class Project : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProjectId;
		
		private string _Name;
		
		private System.DateTime _DateCreated;
		
		private EntitySet<Image> _Images;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProjectIdChanging(int value);
    partial void OnProjectIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    #endregion
		
		public Project()
		{
			this._Images = new EntitySet<Image>(new Action<Image>(this.attach_Images), new Action<Image>(this.detach_Images));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProjectId
		{
			get
			{
				return this._ProjectId;
			}
			set
			{
				if ((this._ProjectId != value))
				{
					this.OnProjectIdChanging(value);
					this.SendPropertyChanging();
					this._ProjectId = value;
					this.SendPropertyChanged("ProjectId");
					this.OnProjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Image", Storage="_Images", ThisKey="ProjectId", OtherKey="ProjectId")]
		public EntitySet<Image> Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				this._Images.Assign(value);
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
		
		private void attach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.Project = this;
		}
		
		private void detach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.Project = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sessions")]
	public partial class Session : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SessionId;
		
		private System.DateTime _DateOfSession;
		
		private string _SessionLabel;
		
		private EntitySet<Image> _Images;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSessionIdChanging(int value);
    partial void OnSessionIdChanged();
    partial void OnDateOfSessionChanging(System.DateTime value);
    partial void OnDateOfSessionChanged();
    partial void OnSessionLabelChanging(string value);
    partial void OnSessionLabelChanged();
    #endregion
		
		public Session()
		{
			this._Images = new EntitySet<Image>(new Action<Image>(this.attach_Images), new Action<Image>(this.detach_Images));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				if ((this._SessionId != value))
				{
					this.OnSessionIdChanging(value);
					this.SendPropertyChanging();
					this._SessionId = value;
					this.SendPropertyChanged("SessionId");
					this.OnSessionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfSession", DbType="DateTime NOT NULL")]
		public System.DateTime DateOfSession
		{
			get
			{
				return this._DateOfSession;
			}
			set
			{
				if ((this._DateOfSession != value))
				{
					this.OnDateOfSessionChanging(value);
					this.SendPropertyChanging();
					this._DateOfSession = value;
					this.SendPropertyChanged("DateOfSession");
					this.OnDateOfSessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionLabel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SessionLabel
		{
			get
			{
				return this._SessionLabel;
			}
			set
			{
				if ((this._SessionLabel != value))
				{
					this.OnSessionLabelChanging(value);
					this.SendPropertyChanging();
					this._SessionLabel = value;
					this.SendPropertyChanged("SessionLabel");
					this.OnSessionLabelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Session_Image", Storage="_Images", ThisKey="SessionId", OtherKey="SessionId")]
		public EntitySet<Image> Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				this._Images.Assign(value);
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
		
		private void attach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.Session = this;
		}
		
		private void detach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.Session = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Image_Deref")]
	public partial class ImagesView
	{
		
		private int _ImageId;
		
		private string _FilePath;
		
		private System.DateTime _DateAdded;
		
		private string _Name;
		
		private string _Expr1;
		
		private string _SessionLabel;
		
		public ImagesView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageId", DbType="Int NOT NULL")]
		public int ImageId
		{
			get
			{
				return this._ImageId;
			}
			set
			{
				if ((this._ImageId != value))
				{
					this._ImageId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilePath", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FilePath
		{
			get
			{
				return this._FilePath;
			}
			set
			{
				if ((this._FilePath != value))
				{
					this._FilePath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAdded", DbType="DateTime NOT NULL")]
		public System.DateTime DateAdded
		{
			get
			{
				return this._DateAdded;
			}
			set
			{
				if ((this._DateAdded != value))
				{
					this._DateAdded = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expr1", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Expr1
		{
			get
			{
				return this._Expr1;
			}
			set
			{
				if ((this._Expr1 != value))
				{
					this._Expr1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionLabel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SessionLabel
		{
			get
			{
				return this._SessionLabel;
			}
			set
			{
				if ((this._SessionLabel != value))
				{
					this._SessionLabel = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
