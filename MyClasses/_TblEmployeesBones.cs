
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
	public abstract class _TblEmployeesBones : SqlClientEntity
	{
		public _TblEmployeesBones()
		{
			this.QuerySource = "TblEmployeesBones";
			this.MappingName = "TblEmployeesBones";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblEmployeesBonesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Bones_ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Bones_ID, Bones_ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblEmployeesBonesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Bones_ID
			{
				get
				{
					return new SqlParameter("@Bones_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Salary_Id
			{
				get
				{
					return new SqlParameter("@Salary_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter User_Id
			{
				get
				{
					return new SqlParameter("@User_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Bones_Money
			{
				get
				{
					return new SqlParameter("@Bones_Money", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Bones_Date
			{
				get
				{
					return new SqlParameter("@Bones_Date", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Bones_Type
			{
				get
				{
					return new SqlParameter("@Bones_Type", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Bones_Details
			{
				get
				{
					return new SqlParameter("@Bones_Details", SqlDbType.NVarChar, 1073741823);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Bones_ID = "Bones_ID";
            public const string Salary_Id = "Salary_Id";
            public const string User_Id = "User_Id";
            public const string Bones_Money = "Bones_Money";
            public const string Bones_Date = "Bones_Date";
            public const string Bones_Type = "Bones_Type";
            public const string Bones_Details = "Bones_Details";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Bones_ID] = _TblEmployeesBones.PropertyNames.Bones_ID;
					ht[Salary_Id] = _TblEmployeesBones.PropertyNames.Salary_Id;
					ht[User_Id] = _TblEmployeesBones.PropertyNames.User_Id;
					ht[Bones_Money] = _TblEmployeesBones.PropertyNames.Bones_Money;
					ht[Bones_Date] = _TblEmployeesBones.PropertyNames.Bones_Date;
					ht[Bones_Type] = _TblEmployeesBones.PropertyNames.Bones_Type;
					ht[Bones_Details] = _TblEmployeesBones.PropertyNames.Bones_Details;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Bones_ID = "Bones_ID";
            public const string Salary_Id = "Salary_Id";
            public const string User_Id = "User_Id";
            public const string Bones_Money = "Bones_Money";
            public const string Bones_Date = "Bones_Date";
            public const string Bones_Type = "Bones_Type";
            public const string Bones_Details = "Bones_Details";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Bones_ID] = _TblEmployeesBones.ColumnNames.Bones_ID;
					ht[Salary_Id] = _TblEmployeesBones.ColumnNames.Salary_Id;
					ht[User_Id] = _TblEmployeesBones.ColumnNames.User_Id;
					ht[Bones_Money] = _TblEmployeesBones.ColumnNames.Bones_Money;
					ht[Bones_Date] = _TblEmployeesBones.ColumnNames.Bones_Date;
					ht[Bones_Type] = _TblEmployeesBones.ColumnNames.Bones_Type;
					ht[Bones_Details] = _TblEmployeesBones.ColumnNames.Bones_Details;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Bones_ID = "s_Bones_ID";
            public const string Salary_Id = "s_Salary_Id";
            public const string User_Id = "s_User_Id";
            public const string Bones_Money = "s_Bones_Money";
            public const string Bones_Date = "s_Bones_Date";
            public const string Bones_Type = "s_Bones_Type";
            public const string Bones_Details = "s_Bones_Details";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Bones_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.Bones_ID);
			}
			set
	        {
				base.Setint(ColumnNames.Bones_ID, value);
			}
		}

		public virtual int Salary_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.Salary_Id);
			}
			set
	        {
				base.Setint(ColumnNames.Salary_Id, value);
			}
		}

		public virtual int User_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.User_Id);
			}
			set
	        {
				base.Setint(ColumnNames.User_Id, value);
			}
		}

		public virtual double Bones_Money
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Bones_Money);
			}
			set
	        {
				base.Setdouble(ColumnNames.Bones_Money, value);
			}
		}

		public virtual DateTime Bones_Date
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Bones_Date);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Bones_Date, value);
			}
		}

		public virtual string Bones_Type
	    {
			get
	        {
				return base.Getstring(ColumnNames.Bones_Type);
			}
			set
	        {
				base.Setstring(ColumnNames.Bones_Type, value);
			}
		}

		public virtual string Bones_Details
	    {
			get
	        {
				return base.Getstring(ColumnNames.Bones_Details);
			}
			set
	        {
				base.Setstring(ColumnNames.Bones_Details, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Bones_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bones_ID) ? string.Empty : base.GetintAsString(ColumnNames.Bones_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bones_ID);
				else
					this.Bones_ID = base.SetintAsString(ColumnNames.Bones_ID, value);
			}
		}

		public virtual string s_Salary_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Salary_Id) ? string.Empty : base.GetintAsString(ColumnNames.Salary_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Salary_Id);
				else
					this.Salary_Id = base.SetintAsString(ColumnNames.Salary_Id, value);
			}
		}

		public virtual string s_User_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.User_Id) ? string.Empty : base.GetintAsString(ColumnNames.User_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.User_Id);
				else
					this.User_Id = base.SetintAsString(ColumnNames.User_Id, value);
			}
		}

		public virtual string s_Bones_Money
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bones_Money) ? string.Empty : base.GetdoubleAsString(ColumnNames.Bones_Money);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bones_Money);
				else
					this.Bones_Money = base.SetdoubleAsString(ColumnNames.Bones_Money, value);
			}
		}

		public virtual string s_Bones_Date
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bones_Date) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Bones_Date);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bones_Date);
				else
					this.Bones_Date = base.SetDateTimeAsString(ColumnNames.Bones_Date, value);
			}
		}

		public virtual string s_Bones_Type
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bones_Type) ? string.Empty : base.GetstringAsString(ColumnNames.Bones_Type);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bones_Type);
				else
					this.Bones_Type = base.SetstringAsString(ColumnNames.Bones_Type, value);
			}
		}

		public virtual string s_Bones_Details
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bones_Details) ? string.Empty : base.GetstringAsString(ColumnNames.Bones_Details);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bones_Details);
				else
					this.Bones_Details = base.SetstringAsString(ColumnNames.Bones_Details, value);
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
				
				
				public WhereParameter Bones_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bones_ID, Parameters.Bones_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Salary_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Salary_Id, Parameters.Salary_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter User_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.User_Id, Parameters.User_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Bones_Money
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bones_Money, Parameters.Bones_Money);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Bones_Date
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bones_Date, Parameters.Bones_Date);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Bones_Type
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bones_Type, Parameters.Bones_Type);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Bones_Details
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bones_Details, Parameters.Bones_Details);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Bones_ID
		    {
				get
		        {
					if(_Bones_ID_W == null)
	        	    {
						_Bones_ID_W = TearOff.Bones_ID;
					}
					return _Bones_ID_W;
				}
			}

			public WhereParameter Salary_Id
		    {
				get
		        {
					if(_Salary_Id_W == null)
	        	    {
						_Salary_Id_W = TearOff.Salary_Id;
					}
					return _Salary_Id_W;
				}
			}

			public WhereParameter User_Id
		    {
				get
		        {
					if(_User_Id_W == null)
	        	    {
						_User_Id_W = TearOff.User_Id;
					}
					return _User_Id_W;
				}
			}

			public WhereParameter Bones_Money
		    {
				get
		        {
					if(_Bones_Money_W == null)
	        	    {
						_Bones_Money_W = TearOff.Bones_Money;
					}
					return _Bones_Money_W;
				}
			}

			public WhereParameter Bones_Date
		    {
				get
		        {
					if(_Bones_Date_W == null)
	        	    {
						_Bones_Date_W = TearOff.Bones_Date;
					}
					return _Bones_Date_W;
				}
			}

			public WhereParameter Bones_Type
		    {
				get
		        {
					if(_Bones_Type_W == null)
	        	    {
						_Bones_Type_W = TearOff.Bones_Type;
					}
					return _Bones_Type_W;
				}
			}

			public WhereParameter Bones_Details
		    {
				get
		        {
					if(_Bones_Details_W == null)
	        	    {
						_Bones_Details_W = TearOff.Bones_Details;
					}
					return _Bones_Details_W;
				}
			}

			private WhereParameter _Bones_ID_W = null;
			private WhereParameter _Salary_Id_W = null;
			private WhereParameter _User_Id_W = null;
			private WhereParameter _Bones_Money_W = null;
			private WhereParameter _Bones_Date_W = null;
			private WhereParameter _Bones_Type_W = null;
			private WhereParameter _Bones_Details_W = null;

			public void WhereClauseReset()
			{
				_Bones_ID_W = null;
				_Salary_Id_W = null;
				_User_Id_W = null;
				_Bones_Money_W = null;
				_Bones_Date_W = null;
				_Bones_Type_W = null;
				_Bones_Details_W = null;

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
				
				
				public AggregateParameter Bones_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bones_ID, Parameters.Bones_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Salary_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Salary_Id, Parameters.Salary_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter User_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.User_Id, Parameters.User_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Bones_Money
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bones_Money, Parameters.Bones_Money);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Bones_Date
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bones_Date, Parameters.Bones_Date);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Bones_Type
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bones_Type, Parameters.Bones_Type);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Bones_Details
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bones_Details, Parameters.Bones_Details);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Bones_ID
		    {
				get
		        {
					if(_Bones_ID_W == null)
	        	    {
						_Bones_ID_W = TearOff.Bones_ID;
					}
					return _Bones_ID_W;
				}
			}

			public AggregateParameter Salary_Id
		    {
				get
		        {
					if(_Salary_Id_W == null)
	        	    {
						_Salary_Id_W = TearOff.Salary_Id;
					}
					return _Salary_Id_W;
				}
			}

			public AggregateParameter User_Id
		    {
				get
		        {
					if(_User_Id_W == null)
	        	    {
						_User_Id_W = TearOff.User_Id;
					}
					return _User_Id_W;
				}
			}

			public AggregateParameter Bones_Money
		    {
				get
		        {
					if(_Bones_Money_W == null)
	        	    {
						_Bones_Money_W = TearOff.Bones_Money;
					}
					return _Bones_Money_W;
				}
			}

			public AggregateParameter Bones_Date
		    {
				get
		        {
					if(_Bones_Date_W == null)
	        	    {
						_Bones_Date_W = TearOff.Bones_Date;
					}
					return _Bones_Date_W;
				}
			}

			public AggregateParameter Bones_Type
		    {
				get
		        {
					if(_Bones_Type_W == null)
	        	    {
						_Bones_Type_W = TearOff.Bones_Type;
					}
					return _Bones_Type_W;
				}
			}

			public AggregateParameter Bones_Details
		    {
				get
		        {
					if(_Bones_Details_W == null)
	        	    {
						_Bones_Details_W = TearOff.Bones_Details;
					}
					return _Bones_Details_W;
				}
			}

			private AggregateParameter _Bones_ID_W = null;
			private AggregateParameter _Salary_Id_W = null;
			private AggregateParameter _User_Id_W = null;
			private AggregateParameter _Bones_Money_W = null;
			private AggregateParameter _Bones_Date_W = null;
			private AggregateParameter _Bones_Type_W = null;
			private AggregateParameter _Bones_Details_W = null;

			public void AggregateClauseReset()
			{
				_Bones_ID_W = null;
				_Salary_Id_W = null;
				_User_Id_W = null;
				_Bones_Money_W = null;
				_Bones_Date_W = null;
				_Bones_Type_W = null;
				_Bones_Details_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblEmployeesBonesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Bones_ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblEmployeesBonesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblEmployeesBonesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Bones_ID);
			p.SourceColumn = ColumnNames.Bones_ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Bones_ID);
			p.SourceColumn = ColumnNames.Bones_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Salary_Id);
			p.SourceColumn = ColumnNames.Salary_Id;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_Id);
			p.SourceColumn = ColumnNames.User_Id;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Bones_Money);
			p.SourceColumn = ColumnNames.Bones_Money;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Bones_Date);
			p.SourceColumn = ColumnNames.Bones_Date;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Bones_Type);
			p.SourceColumn = ColumnNames.Bones_Type;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Bones_Details);
			p.SourceColumn = ColumnNames.Bones_Details;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
