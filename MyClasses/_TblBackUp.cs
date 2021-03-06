
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
	public abstract class _TblBackUp : SqlClientEntity
	{
		public _TblBackUp()
		{
			this.QuerySource = "TblBackUp";
			this.MappingName = "TblBackUp";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblBackUpLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int BackUp_ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.BackUp_ID, BackUp_ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblBackUpLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter BackUp_ID
			{
				get
				{
					return new SqlParameter("@BackUp_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter BackUp_Date
			{
				get
				{
					return new SqlParameter("@BackUp_Date", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter User_Id
			{
				get
				{
					return new SqlParameter("@User_Id", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string BackUp_ID = "BackUp_ID";
            public const string BackUp_Date = "BackUp_Date";
            public const string User_Id = "User_Id";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[BackUp_ID] = _TblBackUp.PropertyNames.BackUp_ID;
					ht[BackUp_Date] = _TblBackUp.PropertyNames.BackUp_Date;
					ht[User_Id] = _TblBackUp.PropertyNames.User_Id;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string BackUp_ID = "BackUp_ID";
            public const string BackUp_Date = "BackUp_Date";
            public const string User_Id = "User_Id";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[BackUp_ID] = _TblBackUp.ColumnNames.BackUp_ID;
					ht[BackUp_Date] = _TblBackUp.ColumnNames.BackUp_Date;
					ht[User_Id] = _TblBackUp.ColumnNames.User_Id;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string BackUp_ID = "s_BackUp_ID";
            public const string BackUp_Date = "s_BackUp_Date";
            public const string User_Id = "s_User_Id";

		}
		#endregion		
		
		#region Properties
	
		public virtual int BackUp_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.BackUp_ID);
			}
			set
	        {
				base.Setint(ColumnNames.BackUp_ID, value);
			}
		}

		public virtual DateTime BackUp_Date
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.BackUp_Date);
			}
			set
	        {
				base.SetDateTime(ColumnNames.BackUp_Date, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_BackUp_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BackUp_ID) ? string.Empty : base.GetintAsString(ColumnNames.BackUp_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BackUp_ID);
				else
					this.BackUp_ID = base.SetintAsString(ColumnNames.BackUp_ID, value);
			}
		}

		public virtual string s_BackUp_Date
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BackUp_Date) ? string.Empty : base.GetDateTimeAsString(ColumnNames.BackUp_Date);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BackUp_Date);
				else
					this.BackUp_Date = base.SetDateTimeAsString(ColumnNames.BackUp_Date, value);
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
				
				
				public WhereParameter BackUp_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BackUp_ID, Parameters.BackUp_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BackUp_Date
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BackUp_Date, Parameters.BackUp_Date);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter BackUp_ID
		    {
				get
		        {
					if(_BackUp_ID_W == null)
	        	    {
						_BackUp_ID_W = TearOff.BackUp_ID;
					}
					return _BackUp_ID_W;
				}
			}

			public WhereParameter BackUp_Date
		    {
				get
		        {
					if(_BackUp_Date_W == null)
	        	    {
						_BackUp_Date_W = TearOff.BackUp_Date;
					}
					return _BackUp_Date_W;
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

			private WhereParameter _BackUp_ID_W = null;
			private WhereParameter _BackUp_Date_W = null;
			private WhereParameter _User_Id_W = null;

			public void WhereClauseReset()
			{
				_BackUp_ID_W = null;
				_BackUp_Date_W = null;
				_User_Id_W = null;

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
				
				
				public AggregateParameter BackUp_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BackUp_ID, Parameters.BackUp_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BackUp_Date
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BackUp_Date, Parameters.BackUp_Date);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter BackUp_ID
		    {
				get
		        {
					if(_BackUp_ID_W == null)
	        	    {
						_BackUp_ID_W = TearOff.BackUp_ID;
					}
					return _BackUp_ID_W;
				}
			}

			public AggregateParameter BackUp_Date
		    {
				get
		        {
					if(_BackUp_Date_W == null)
	        	    {
						_BackUp_Date_W = TearOff.BackUp_Date;
					}
					return _BackUp_Date_W;
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

			private AggregateParameter _BackUp_ID_W = null;
			private AggregateParameter _BackUp_Date_W = null;
			private AggregateParameter _User_Id_W = null;

			public void AggregateClauseReset()
			{
				_BackUp_ID_W = null;
				_BackUp_Date_W = null;
				_User_Id_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblBackUpInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.BackUp_ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblBackUpUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblBackUpDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.BackUp_ID);
			p.SourceColumn = ColumnNames.BackUp_ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.BackUp_ID);
			p.SourceColumn = ColumnNames.BackUp_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BackUp_Date);
			p.SourceColumn = ColumnNames.BackUp_Date;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_Id);
			p.SourceColumn = ColumnNames.User_Id;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
