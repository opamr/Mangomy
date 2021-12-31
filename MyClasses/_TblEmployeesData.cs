
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace MyPro
{
	public abstract class _TblEmployeesData : SqlClientEntity
	{
		public _TblEmployeesData()
		{
			this.QuerySource = "TblEmployeesData";
			this.MappingName = "TblEmployeesData";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblEmployeesDataLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Emp_ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Emp_ID, Emp_ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblEmployeesDataLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Emp_ID
			{
				get
				{
					return new SqlParameter("@Emp_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Emp_StartDate
			{
				get
				{
					return new SqlParameter("@Emp_StartDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Emp_Name
			{
				get
				{
					return new SqlParameter("@Emp_Name", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Emp_Special
			{
				get
				{
					return new SqlParameter("@Emp_Special", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Emp_Mobile
			{
				get
				{
					return new SqlParameter("@Emp_Mobile", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Emp_Nationality
			{
				get
				{
					return new SqlParameter("@Emp_Nationality", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Emp_Identity
			{
				get
				{
					return new SqlParameter("@Emp_Identity", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Emp_IdentityDate
			{
				get
				{
					return new SqlParameter("@Emp_IdentityDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Emp_Salary
			{
				get
				{
					return new SqlParameter("@Emp_Salary", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Emp_House
			{
				get
				{
					return new SqlParameter("@Emp_House", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Emp_Archive
			{
				get
				{
					return new SqlParameter("@Emp_Archive", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Emp_ArchiveDate
			{
				get
				{
					return new SqlParameter("@Emp_ArchiveDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter EmpArchiveReson
			{
				get
				{
					return new SqlParameter("@EmpArchiveReson", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Emp_Address
			{
				get
				{
					return new SqlParameter("@Emp_Address", SqlDbType.NVarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Emp_ID = "Emp_ID";
            public const string Emp_StartDate = "Emp_StartDate";
            public const string Emp_Name = "Emp_Name";
            public const string Emp_Special = "Emp_Special";
            public const string Emp_Mobile = "Emp_Mobile";
            public const string Emp_Nationality = "Emp_Nationality";
            public const string Emp_Identity = "Emp_Identity";
            public const string Emp_IdentityDate = "Emp_IdentityDate";
            public const string Emp_Salary = "Emp_Salary";
            public const string Emp_House = "Emp_House";
            public const string Emp_Archive = "Emp_Archive";
            public const string Emp_ArchiveDate = "Emp_ArchiveDate";
            public const string EmpArchiveReson = "EmpArchiveReson";
            public const string Emp_Address = "Emp_Address";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Emp_ID] = _TblEmployeesData.PropertyNames.Emp_ID;
					ht[Emp_StartDate] = _TblEmployeesData.PropertyNames.Emp_StartDate;
					ht[Emp_Name] = _TblEmployeesData.PropertyNames.Emp_Name;
					ht[Emp_Special] = _TblEmployeesData.PropertyNames.Emp_Special;
					ht[Emp_Mobile] = _TblEmployeesData.PropertyNames.Emp_Mobile;
					ht[Emp_Nationality] = _TblEmployeesData.PropertyNames.Emp_Nationality;
					ht[Emp_Identity] = _TblEmployeesData.PropertyNames.Emp_Identity;
					ht[Emp_IdentityDate] = _TblEmployeesData.PropertyNames.Emp_IdentityDate;
					ht[Emp_Salary] = _TblEmployeesData.PropertyNames.Emp_Salary;
					ht[Emp_House] = _TblEmployeesData.PropertyNames.Emp_House;
					ht[Emp_Archive] = _TblEmployeesData.PropertyNames.Emp_Archive;
					ht[Emp_ArchiveDate] = _TblEmployeesData.PropertyNames.Emp_ArchiveDate;
					ht[EmpArchiveReson] = _TblEmployeesData.PropertyNames.EmpArchiveReson;
					ht[Emp_Address] = _TblEmployeesData.PropertyNames.Emp_Address;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Emp_ID = "Emp_ID";
            public const string Emp_StartDate = "Emp_StartDate";
            public const string Emp_Name = "Emp_Name";
            public const string Emp_Special = "Emp_Special";
            public const string Emp_Mobile = "Emp_Mobile";
            public const string Emp_Nationality = "Emp_Nationality";
            public const string Emp_Identity = "Emp_Identity";
            public const string Emp_IdentityDate = "Emp_IdentityDate";
            public const string Emp_Salary = "Emp_Salary";
            public const string Emp_House = "Emp_House";
            public const string Emp_Archive = "Emp_Archive";
            public const string Emp_ArchiveDate = "Emp_ArchiveDate";
            public const string EmpArchiveReson = "EmpArchiveReson";
            public const string Emp_Address = "Emp_Address";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Emp_ID] = _TblEmployeesData.ColumnNames.Emp_ID;
					ht[Emp_StartDate] = _TblEmployeesData.ColumnNames.Emp_StartDate;
					ht[Emp_Name] = _TblEmployeesData.ColumnNames.Emp_Name;
					ht[Emp_Special] = _TblEmployeesData.ColumnNames.Emp_Special;
					ht[Emp_Mobile] = _TblEmployeesData.ColumnNames.Emp_Mobile;
					ht[Emp_Nationality] = _TblEmployeesData.ColumnNames.Emp_Nationality;
					ht[Emp_Identity] = _TblEmployeesData.ColumnNames.Emp_Identity;
					ht[Emp_IdentityDate] = _TblEmployeesData.ColumnNames.Emp_IdentityDate;
					ht[Emp_Salary] = _TblEmployeesData.ColumnNames.Emp_Salary;
					ht[Emp_House] = _TblEmployeesData.ColumnNames.Emp_House;
					ht[Emp_Archive] = _TblEmployeesData.ColumnNames.Emp_Archive;
					ht[Emp_ArchiveDate] = _TblEmployeesData.ColumnNames.Emp_ArchiveDate;
					ht[EmpArchiveReson] = _TblEmployeesData.ColumnNames.EmpArchiveReson;
					ht[Emp_Address] = _TblEmployeesData.ColumnNames.Emp_Address;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Emp_ID = "s_Emp_ID";
            public const string Emp_StartDate = "s_Emp_StartDate";
            public const string Emp_Name = "s_Emp_Name";
            public const string Emp_Special = "s_Emp_Special";
            public const string Emp_Mobile = "s_Emp_Mobile";
            public const string Emp_Nationality = "s_Emp_Nationality";
            public const string Emp_Identity = "s_Emp_Identity";
            public const string Emp_IdentityDate = "s_Emp_IdentityDate";
            public const string Emp_Salary = "s_Emp_Salary";
            public const string Emp_House = "s_Emp_House";
            public const string Emp_Archive = "s_Emp_Archive";
            public const string Emp_ArchiveDate = "s_Emp_ArchiveDate";
            public const string EmpArchiveReson = "s_EmpArchiveReson";
            public const string Emp_Address = "s_Emp_Address";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Emp_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.Emp_ID);
			}
			set
	        {
				base.Setint(ColumnNames.Emp_ID, value);
			}
		}

		public virtual DateTime Emp_StartDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Emp_StartDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Emp_StartDate, value);
			}
		}

		public virtual string Emp_Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emp_Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Emp_Name, value);
			}
		}

		public virtual string Emp_Special
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emp_Special);
			}
			set
	        {
				base.Setstring(ColumnNames.Emp_Special, value);
			}
		}

		public virtual string Emp_Mobile
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emp_Mobile);
			}
			set
	        {
				base.Setstring(ColumnNames.Emp_Mobile, value);
			}
		}

		public virtual string Emp_Nationality
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emp_Nationality);
			}
			set
	        {
				base.Setstring(ColumnNames.Emp_Nationality, value);
			}
		}

		public virtual string Emp_Identity
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emp_Identity);
			}
			set
	        {
				base.Setstring(ColumnNames.Emp_Identity, value);
			}
		}

		public virtual DateTime Emp_IdentityDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Emp_IdentityDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Emp_IdentityDate, value);
			}
		}

		public virtual double Emp_Salary
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Emp_Salary);
			}
			set
	        {
				base.Setdouble(ColumnNames.Emp_Salary, value);
			}
		}

		public virtual double Emp_House
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Emp_House);
			}
			set
	        {
				base.Setdouble(ColumnNames.Emp_House, value);
			}
		}

		public virtual string Emp_Archive
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emp_Archive);
			}
			set
	        {
				base.Setstring(ColumnNames.Emp_Archive, value);
			}
		}

		public virtual DateTime Emp_ArchiveDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Emp_ArchiveDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Emp_ArchiveDate, value);
			}
		}

		public virtual string EmpArchiveReson
	    {
			get
	        {
				return base.Getstring(ColumnNames.EmpArchiveReson);
			}
			set
	        {
				base.Setstring(ColumnNames.EmpArchiveReson, value);
			}
		}

		public virtual string Emp_Address
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emp_Address);
			}
			set
	        {
				base.Setstring(ColumnNames.Emp_Address, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Emp_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_ID) ? string.Empty : base.GetintAsString(ColumnNames.Emp_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_ID);
				else
					this.Emp_ID = base.SetintAsString(ColumnNames.Emp_ID, value);
			}
		}

		public virtual string s_Emp_StartDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_StartDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Emp_StartDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_StartDate);
				else
					this.Emp_StartDate = base.SetDateTimeAsString(ColumnNames.Emp_StartDate, value);
			}
		}

		public virtual string s_Emp_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Name) ? string.Empty : base.GetstringAsString(ColumnNames.Emp_Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Name);
				else
					this.Emp_Name = base.SetstringAsString(ColumnNames.Emp_Name, value);
			}
		}

		public virtual string s_Emp_Special
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Special) ? string.Empty : base.GetstringAsString(ColumnNames.Emp_Special);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Special);
				else
					this.Emp_Special = base.SetstringAsString(ColumnNames.Emp_Special, value);
			}
		}

		public virtual string s_Emp_Mobile
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Mobile) ? string.Empty : base.GetstringAsString(ColumnNames.Emp_Mobile);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Mobile);
				else
					this.Emp_Mobile = base.SetstringAsString(ColumnNames.Emp_Mobile, value);
			}
		}

		public virtual string s_Emp_Nationality
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Nationality) ? string.Empty : base.GetstringAsString(ColumnNames.Emp_Nationality);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Nationality);
				else
					this.Emp_Nationality = base.SetstringAsString(ColumnNames.Emp_Nationality, value);
			}
		}

		public virtual string s_Emp_Identity
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Identity) ? string.Empty : base.GetstringAsString(ColumnNames.Emp_Identity);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Identity);
				else
					this.Emp_Identity = base.SetstringAsString(ColumnNames.Emp_Identity, value);
			}
		}

		public virtual string s_Emp_IdentityDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_IdentityDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Emp_IdentityDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_IdentityDate);
				else
					this.Emp_IdentityDate = base.SetDateTimeAsString(ColumnNames.Emp_IdentityDate, value);
			}
		}

		public virtual string s_Emp_Salary
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Salary) ? string.Empty : base.GetdoubleAsString(ColumnNames.Emp_Salary);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Salary);
				else
					this.Emp_Salary = base.SetdoubleAsString(ColumnNames.Emp_Salary, value);
			}
		}

		public virtual string s_Emp_House
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_House) ? string.Empty : base.GetdoubleAsString(ColumnNames.Emp_House);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_House);
				else
					this.Emp_House = base.SetdoubleAsString(ColumnNames.Emp_House, value);
			}
		}

		public virtual string s_Emp_Archive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Archive) ? string.Empty : base.GetstringAsString(ColumnNames.Emp_Archive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Archive);
				else
					this.Emp_Archive = base.SetstringAsString(ColumnNames.Emp_Archive, value);
			}
		}

		public virtual string s_Emp_ArchiveDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_ArchiveDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Emp_ArchiveDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_ArchiveDate);
				else
					this.Emp_ArchiveDate = base.SetDateTimeAsString(ColumnNames.Emp_ArchiveDate, value);
			}
		}

		public virtual string s_EmpArchiveReson
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EmpArchiveReson) ? string.Empty : base.GetstringAsString(ColumnNames.EmpArchiveReson);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EmpArchiveReson);
				else
					this.EmpArchiveReson = base.SetstringAsString(ColumnNames.EmpArchiveReson, value);
			}
		}

		public virtual string s_Emp_Address
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emp_Address) ? string.Empty : base.GetstringAsString(ColumnNames.Emp_Address);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emp_Address);
				else
					this.Emp_Address = base.SetstringAsString(ColumnNames.Emp_Address, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter Emp_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_ID, Parameters.Emp_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_StartDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_StartDate, Parameters.Emp_StartDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Name, Parameters.Emp_Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Special
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Special, Parameters.Emp_Special);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Mobile
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Mobile, Parameters.Emp_Mobile);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Nationality
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Nationality, Parameters.Emp_Nationality);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Identity
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Identity, Parameters.Emp_Identity);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_IdentityDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_IdentityDate, Parameters.Emp_IdentityDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Salary
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Salary, Parameters.Emp_Salary);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_House
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_House, Parameters.Emp_House);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Archive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Archive, Parameters.Emp_Archive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_ArchiveDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_ArchiveDate, Parameters.Emp_ArchiveDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EmpArchiveReson
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EmpArchiveReson, Parameters.EmpArchiveReson);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emp_Address
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emp_Address, Parameters.Emp_Address);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Emp_ID
		    {
				get
		        {
					if(_Emp_ID_W == null)
	        	    {
						_Emp_ID_W = TearOff.Emp_ID;
					}
					return _Emp_ID_W;
				}
			}

			public WhereParameter Emp_StartDate
		    {
				get
		        {
					if(_Emp_StartDate_W == null)
	        	    {
						_Emp_StartDate_W = TearOff.Emp_StartDate;
					}
					return _Emp_StartDate_W;
				}
			}

			public WhereParameter Emp_Name
		    {
				get
		        {
					if(_Emp_Name_W == null)
	        	    {
						_Emp_Name_W = TearOff.Emp_Name;
					}
					return _Emp_Name_W;
				}
			}

			public WhereParameter Emp_Special
		    {
				get
		        {
					if(_Emp_Special_W == null)
	        	    {
						_Emp_Special_W = TearOff.Emp_Special;
					}
					return _Emp_Special_W;
				}
			}

			public WhereParameter Emp_Mobile
		    {
				get
		        {
					if(_Emp_Mobile_W == null)
	        	    {
						_Emp_Mobile_W = TearOff.Emp_Mobile;
					}
					return _Emp_Mobile_W;
				}
			}

			public WhereParameter Emp_Nationality
		    {
				get
		        {
					if(_Emp_Nationality_W == null)
	        	    {
						_Emp_Nationality_W = TearOff.Emp_Nationality;
					}
					return _Emp_Nationality_W;
				}
			}

			public WhereParameter Emp_Identity
		    {
				get
		        {
					if(_Emp_Identity_W == null)
	        	    {
						_Emp_Identity_W = TearOff.Emp_Identity;
					}
					return _Emp_Identity_W;
				}
			}

			public WhereParameter Emp_IdentityDate
		    {
				get
		        {
					if(_Emp_IdentityDate_W == null)
	        	    {
						_Emp_IdentityDate_W = TearOff.Emp_IdentityDate;
					}
					return _Emp_IdentityDate_W;
				}
			}

			public WhereParameter Emp_Salary
		    {
				get
		        {
					if(_Emp_Salary_W == null)
	        	    {
						_Emp_Salary_W = TearOff.Emp_Salary;
					}
					return _Emp_Salary_W;
				}
			}

			public WhereParameter Emp_House
		    {
				get
		        {
					if(_Emp_House_W == null)
	        	    {
						_Emp_House_W = TearOff.Emp_House;
					}
					return _Emp_House_W;
				}
			}

			public WhereParameter Emp_Archive
		    {
				get
		        {
					if(_Emp_Archive_W == null)
	        	    {
						_Emp_Archive_W = TearOff.Emp_Archive;
					}
					return _Emp_Archive_W;
				}
			}

			public WhereParameter Emp_ArchiveDate
		    {
				get
		        {
					if(_Emp_ArchiveDate_W == null)
	        	    {
						_Emp_ArchiveDate_W = TearOff.Emp_ArchiveDate;
					}
					return _Emp_ArchiveDate_W;
				}
			}

			public WhereParameter EmpArchiveReson
		    {
				get
		        {
					if(_EmpArchiveReson_W == null)
	        	    {
						_EmpArchiveReson_W = TearOff.EmpArchiveReson;
					}
					return _EmpArchiveReson_W;
				}
			}

			public WhereParameter Emp_Address
		    {
				get
		        {
					if(_Emp_Address_W == null)
	        	    {
						_Emp_Address_W = TearOff.Emp_Address;
					}
					return _Emp_Address_W;
				}
			}

			private WhereParameter _Emp_ID_W = null;
			private WhereParameter _Emp_StartDate_W = null;
			private WhereParameter _Emp_Name_W = null;
			private WhereParameter _Emp_Special_W = null;
			private WhereParameter _Emp_Mobile_W = null;
			private WhereParameter _Emp_Nationality_W = null;
			private WhereParameter _Emp_Identity_W = null;
			private WhereParameter _Emp_IdentityDate_W = null;
			private WhereParameter _Emp_Salary_W = null;
			private WhereParameter _Emp_House_W = null;
			private WhereParameter _Emp_Archive_W = null;
			private WhereParameter _Emp_ArchiveDate_W = null;
			private WhereParameter _EmpArchiveReson_W = null;
			private WhereParameter _Emp_Address_W = null;

			public void WhereClauseReset()
			{
				_Emp_ID_W = null;
				_Emp_StartDate_W = null;
				_Emp_Name_W = null;
				_Emp_Special_W = null;
				_Emp_Mobile_W = null;
				_Emp_Nationality_W = null;
				_Emp_Identity_W = null;
				_Emp_IdentityDate_W = null;
				_Emp_Salary_W = null;
				_Emp_House_W = null;
				_Emp_Archive_W = null;
				_Emp_ArchiveDate_W = null;
				_EmpArchiveReson_W = null;
				_Emp_Address_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter Emp_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_ID, Parameters.Emp_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_StartDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_StartDate, Parameters.Emp_StartDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Name, Parameters.Emp_Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Special
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Special, Parameters.Emp_Special);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Mobile
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Mobile, Parameters.Emp_Mobile);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Nationality
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Nationality, Parameters.Emp_Nationality);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Identity
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Identity, Parameters.Emp_Identity);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_IdentityDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_IdentityDate, Parameters.Emp_IdentityDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Salary
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Salary, Parameters.Emp_Salary);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_House
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_House, Parameters.Emp_House);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Archive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Archive, Parameters.Emp_Archive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_ArchiveDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_ArchiveDate, Parameters.Emp_ArchiveDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EmpArchiveReson
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EmpArchiveReson, Parameters.EmpArchiveReson);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emp_Address
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emp_Address, Parameters.Emp_Address);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Emp_ID
		    {
				get
		        {
					if(_Emp_ID_W == null)
	        	    {
						_Emp_ID_W = TearOff.Emp_ID;
					}
					return _Emp_ID_W;
				}
			}

			public AggregateParameter Emp_StartDate
		    {
				get
		        {
					if(_Emp_StartDate_W == null)
	        	    {
						_Emp_StartDate_W = TearOff.Emp_StartDate;
					}
					return _Emp_StartDate_W;
				}
			}

			public AggregateParameter Emp_Name
		    {
				get
		        {
					if(_Emp_Name_W == null)
	        	    {
						_Emp_Name_W = TearOff.Emp_Name;
					}
					return _Emp_Name_W;
				}
			}

			public AggregateParameter Emp_Special
		    {
				get
		        {
					if(_Emp_Special_W == null)
	        	    {
						_Emp_Special_W = TearOff.Emp_Special;
					}
					return _Emp_Special_W;
				}
			}

			public AggregateParameter Emp_Mobile
		    {
				get
		        {
					if(_Emp_Mobile_W == null)
	        	    {
						_Emp_Mobile_W = TearOff.Emp_Mobile;
					}
					return _Emp_Mobile_W;
				}
			}

			public AggregateParameter Emp_Nationality
		    {
				get
		        {
					if(_Emp_Nationality_W == null)
	        	    {
						_Emp_Nationality_W = TearOff.Emp_Nationality;
					}
					return _Emp_Nationality_W;
				}
			}

			public AggregateParameter Emp_Identity
		    {
				get
		        {
					if(_Emp_Identity_W == null)
	        	    {
						_Emp_Identity_W = TearOff.Emp_Identity;
					}
					return _Emp_Identity_W;
				}
			}

			public AggregateParameter Emp_IdentityDate
		    {
				get
		        {
					if(_Emp_IdentityDate_W == null)
	        	    {
						_Emp_IdentityDate_W = TearOff.Emp_IdentityDate;
					}
					return _Emp_IdentityDate_W;
				}
			}

			public AggregateParameter Emp_Salary
		    {
				get
		        {
					if(_Emp_Salary_W == null)
	        	    {
						_Emp_Salary_W = TearOff.Emp_Salary;
					}
					return _Emp_Salary_W;
				}
			}

			public AggregateParameter Emp_House
		    {
				get
		        {
					if(_Emp_House_W == null)
	        	    {
						_Emp_House_W = TearOff.Emp_House;
					}
					return _Emp_House_W;
				}
			}

			public AggregateParameter Emp_Archive
		    {
				get
		        {
					if(_Emp_Archive_W == null)
	        	    {
						_Emp_Archive_W = TearOff.Emp_Archive;
					}
					return _Emp_Archive_W;
				}
			}

			public AggregateParameter Emp_ArchiveDate
		    {
				get
		        {
					if(_Emp_ArchiveDate_W == null)
	        	    {
						_Emp_ArchiveDate_W = TearOff.Emp_ArchiveDate;
					}
					return _Emp_ArchiveDate_W;
				}
			}

			public AggregateParameter EmpArchiveReson
		    {
				get
		        {
					if(_EmpArchiveReson_W == null)
	        	    {
						_EmpArchiveReson_W = TearOff.EmpArchiveReson;
					}
					return _EmpArchiveReson_W;
				}
			}

			public AggregateParameter Emp_Address
		    {
				get
		        {
					if(_Emp_Address_W == null)
	        	    {
						_Emp_Address_W = TearOff.Emp_Address;
					}
					return _Emp_Address_W;
				}
			}

			private AggregateParameter _Emp_ID_W = null;
			private AggregateParameter _Emp_StartDate_W = null;
			private AggregateParameter _Emp_Name_W = null;
			private AggregateParameter _Emp_Special_W = null;
			private AggregateParameter _Emp_Mobile_W = null;
			private AggregateParameter _Emp_Nationality_W = null;
			private AggregateParameter _Emp_Identity_W = null;
			private AggregateParameter _Emp_IdentityDate_W = null;
			private AggregateParameter _Emp_Salary_W = null;
			private AggregateParameter _Emp_House_W = null;
			private AggregateParameter _Emp_Archive_W = null;
			private AggregateParameter _Emp_ArchiveDate_W = null;
			private AggregateParameter _EmpArchiveReson_W = null;
			private AggregateParameter _Emp_Address_W = null;

			public void AggregateClauseReset()
			{
				_Emp_ID_W = null;
				_Emp_StartDate_W = null;
				_Emp_Name_W = null;
				_Emp_Special_W = null;
				_Emp_Mobile_W = null;
				_Emp_Nationality_W = null;
				_Emp_Identity_W = null;
				_Emp_IdentityDate_W = null;
				_Emp_Salary_W = null;
				_Emp_House_W = null;
				_Emp_Archive_W = null;
				_Emp_ArchiveDate_W = null;
				_EmpArchiveReson_W = null;
				_Emp_Address_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblEmployeesDataInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Emp_ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblEmployeesDataUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblEmployeesDataDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Emp_ID);
			p.SourceColumn = ColumnNames.Emp_ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Emp_ID);
			p.SourceColumn = ColumnNames.Emp_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_StartDate);
			p.SourceColumn = ColumnNames.Emp_StartDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Name);
			p.SourceColumn = ColumnNames.Emp_Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Special);
			p.SourceColumn = ColumnNames.Emp_Special;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Mobile);
			p.SourceColumn = ColumnNames.Emp_Mobile;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Nationality);
			p.SourceColumn = ColumnNames.Emp_Nationality;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Identity);
			p.SourceColumn = ColumnNames.Emp_Identity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_IdentityDate);
			p.SourceColumn = ColumnNames.Emp_IdentityDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Salary);
			p.SourceColumn = ColumnNames.Emp_Salary;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_House);
			p.SourceColumn = ColumnNames.Emp_House;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Archive);
			p.SourceColumn = ColumnNames.Emp_Archive;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_ArchiveDate);
			p.SourceColumn = ColumnNames.Emp_ArchiveDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EmpArchiveReson);
			p.SourceColumn = ColumnNames.EmpArchiveReson;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emp_Address);
			p.SourceColumn = ColumnNames.Emp_Address;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
