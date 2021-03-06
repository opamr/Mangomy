
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
	public abstract class _TblMessagePublicNumbers : SqlClientEntity
	{
		public _TblMessagePublicNumbers()
		{
			this.QuerySource = "TblMessagePublicNumbers";
			this.MappingName = "TblMessagePublicNumbers";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblMessagePublicNumbersLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Num_ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Num_ID, Num_ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblMessagePublicNumbersLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Num_ID
			{
				get
				{
					return new SqlParameter("@Num_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Num_Name
			{
				get
				{
					return new SqlParameter("@Num_Name", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Number
			{
				get
				{
					return new SqlParameter("@Number", SqlDbType.NChar, 10);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Num_ID = "Num_ID";
            public const string Num_Name = "Num_Name";
            public const string Number = "Number";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Num_ID] = _TblMessagePublicNumbers.PropertyNames.Num_ID;
					ht[Num_Name] = _TblMessagePublicNumbers.PropertyNames.Num_Name;
					ht[Number] = _TblMessagePublicNumbers.PropertyNames.Number;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Num_ID = "Num_ID";
            public const string Num_Name = "Num_Name";
            public const string Number = "Number";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Num_ID] = _TblMessagePublicNumbers.ColumnNames.Num_ID;
					ht[Num_Name] = _TblMessagePublicNumbers.ColumnNames.Num_Name;
					ht[Number] = _TblMessagePublicNumbers.ColumnNames.Number;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Num_ID = "s_Num_ID";
            public const string Num_Name = "s_Num_Name";
            public const string Number = "s_Number";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Num_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.Num_ID);
			}
			set
	        {
				base.Setint(ColumnNames.Num_ID, value);
			}
		}

		public virtual string Num_Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Num_Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Num_Name, value);
			}
		}

		public virtual string Number
	    {
			get
	        {
				return base.Getstring(ColumnNames.Number);
			}
			set
	        {
				base.Setstring(ColumnNames.Number, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Num_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Num_ID) ? string.Empty : base.GetintAsString(ColumnNames.Num_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Num_ID);
				else
					this.Num_ID = base.SetintAsString(ColumnNames.Num_ID, value);
			}
		}

		public virtual string s_Num_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Num_Name) ? string.Empty : base.GetstringAsString(ColumnNames.Num_Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Num_Name);
				else
					this.Num_Name = base.SetstringAsString(ColumnNames.Num_Name, value);
			}
		}

		public virtual string s_Number
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Number) ? string.Empty : base.GetstringAsString(ColumnNames.Number);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Number);
				else
					this.Number = base.SetstringAsString(ColumnNames.Number, value);
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
				
				
				public WhereParameter Num_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Num_ID, Parameters.Num_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Num_Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Num_Name, Parameters.Num_Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Number
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Number, Parameters.Number);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Num_ID
		    {
				get
		        {
					if(_Num_ID_W == null)
	        	    {
						_Num_ID_W = TearOff.Num_ID;
					}
					return _Num_ID_W;
				}
			}

			public WhereParameter Num_Name
		    {
				get
		        {
					if(_Num_Name_W == null)
	        	    {
						_Num_Name_W = TearOff.Num_Name;
					}
					return _Num_Name_W;
				}
			}

			public WhereParameter Number
		    {
				get
		        {
					if(_Number_W == null)
	        	    {
						_Number_W = TearOff.Number;
					}
					return _Number_W;
				}
			}

			private WhereParameter _Num_ID_W = null;
			private WhereParameter _Num_Name_W = null;
			private WhereParameter _Number_W = null;

			public void WhereClauseReset()
			{
				_Num_ID_W = null;
				_Num_Name_W = null;
				_Number_W = null;

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
				
				
				public AggregateParameter Num_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Num_ID, Parameters.Num_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Num_Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Num_Name, Parameters.Num_Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Number
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Number, Parameters.Number);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Num_ID
		    {
				get
		        {
					if(_Num_ID_W == null)
	        	    {
						_Num_ID_W = TearOff.Num_ID;
					}
					return _Num_ID_W;
				}
			}

			public AggregateParameter Num_Name
		    {
				get
		        {
					if(_Num_Name_W == null)
	        	    {
						_Num_Name_W = TearOff.Num_Name;
					}
					return _Num_Name_W;
				}
			}

			public AggregateParameter Number
		    {
				get
		        {
					if(_Number_W == null)
	        	    {
						_Number_W = TearOff.Number;
					}
					return _Number_W;
				}
			}

			private AggregateParameter _Num_ID_W = null;
			private AggregateParameter _Num_Name_W = null;
			private AggregateParameter _Number_W = null;

			public void AggregateClauseReset()
			{
				_Num_ID_W = null;
				_Num_Name_W = null;
				_Number_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblMessagePublicNumbersInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Num_ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblMessagePublicNumbersUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblMessagePublicNumbersDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Num_ID);
			p.SourceColumn = ColumnNames.Num_ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Num_ID);
			p.SourceColumn = ColumnNames.Num_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Num_Name);
			p.SourceColumn = ColumnNames.Num_Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Number);
			p.SourceColumn = ColumnNames.Number;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
