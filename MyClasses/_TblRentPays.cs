
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
	public abstract class _TblRentPays : SqlClientEntity
	{
		public _TblRentPays()
		{
			this.QuerySource = "TblRentPays";
			this.MappingName = "TblRentPays";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblRentPaysLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Pay_ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Pay_ID, Pay_ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblRentPaysLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Pay_ID
			{
				get
				{
					return new SqlParameter("@Pay_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Rent_Id
			{
				get
				{
					return new SqlParameter("@Rent_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Pay_From
			{
				get
				{
					return new SqlParameter("@Pay_From", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Pay_To
			{
				get
				{
					return new SqlParameter("@Pay_To", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Pay_RequiredMoney
			{
				get
				{
					return new SqlParameter("@Pay_RequiredMoney", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Pay_Status
			{
				get
				{
					return new SqlParameter("@Pay_Status", SqlDbType.NVarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Pay_ID = "Pay_ID";
            public const string Rent_Id = "Rent_Id";
            public const string Pay_From = "Pay_From";
            public const string Pay_To = "Pay_To";
            public const string Pay_RequiredMoney = "Pay_RequiredMoney";
            public const string Pay_Status = "Pay_Status";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Pay_ID] = _TblRentPays.PropertyNames.Pay_ID;
					ht[Rent_Id] = _TblRentPays.PropertyNames.Rent_Id;
					ht[Pay_From] = _TblRentPays.PropertyNames.Pay_From;
					ht[Pay_To] = _TblRentPays.PropertyNames.Pay_To;
					ht[Pay_RequiredMoney] = _TblRentPays.PropertyNames.Pay_RequiredMoney;
					ht[Pay_Status] = _TblRentPays.PropertyNames.Pay_Status;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Pay_ID = "Pay_ID";
            public const string Rent_Id = "Rent_Id";
            public const string Pay_From = "Pay_From";
            public const string Pay_To = "Pay_To";
            public const string Pay_RequiredMoney = "Pay_RequiredMoney";
            public const string Pay_Status = "Pay_Status";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Pay_ID] = _TblRentPays.ColumnNames.Pay_ID;
					ht[Rent_Id] = _TblRentPays.ColumnNames.Rent_Id;
					ht[Pay_From] = _TblRentPays.ColumnNames.Pay_From;
					ht[Pay_To] = _TblRentPays.ColumnNames.Pay_To;
					ht[Pay_RequiredMoney] = _TblRentPays.ColumnNames.Pay_RequiredMoney;
					ht[Pay_Status] = _TblRentPays.ColumnNames.Pay_Status;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Pay_ID = "s_Pay_ID";
            public const string Rent_Id = "s_Rent_Id";
            public const string Pay_From = "s_Pay_From";
            public const string Pay_To = "s_Pay_To";
            public const string Pay_RequiredMoney = "s_Pay_RequiredMoney";
            public const string Pay_Status = "s_Pay_Status";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Pay_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.Pay_ID);
			}
			set
	        {
				base.Setint(ColumnNames.Pay_ID, value);
			}
		}

		public virtual int Rent_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.Rent_Id);
			}
			set
	        {
				base.Setint(ColumnNames.Rent_Id, value);
			}
		}

		public virtual DateTime Pay_From
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Pay_From);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Pay_From, value);
			}
		}

		public virtual DateTime Pay_To
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Pay_To);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Pay_To, value);
			}
		}

		public virtual double Pay_RequiredMoney
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Pay_RequiredMoney);
			}
			set
	        {
				base.Setdouble(ColumnNames.Pay_RequiredMoney, value);
			}
		}

		public virtual string Pay_Status
	    {
			get
	        {
				return base.Getstring(ColumnNames.Pay_Status);
			}
			set
	        {
				base.Setstring(ColumnNames.Pay_Status, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Pay_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_ID) ? string.Empty : base.GetintAsString(ColumnNames.Pay_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_ID);
				else
					this.Pay_ID = base.SetintAsString(ColumnNames.Pay_ID, value);
			}
		}

		public virtual string s_Rent_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Rent_Id) ? string.Empty : base.GetintAsString(ColumnNames.Rent_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Rent_Id);
				else
					this.Rent_Id = base.SetintAsString(ColumnNames.Rent_Id, value);
			}
		}

		public virtual string s_Pay_From
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_From) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Pay_From);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_From);
				else
					this.Pay_From = base.SetDateTimeAsString(ColumnNames.Pay_From, value);
			}
		}

		public virtual string s_Pay_To
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_To) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Pay_To);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_To);
				else
					this.Pay_To = base.SetDateTimeAsString(ColumnNames.Pay_To, value);
			}
		}

		public virtual string s_Pay_RequiredMoney
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_RequiredMoney) ? string.Empty : base.GetdoubleAsString(ColumnNames.Pay_RequiredMoney);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_RequiredMoney);
				else
					this.Pay_RequiredMoney = base.SetdoubleAsString(ColumnNames.Pay_RequiredMoney, value);
			}
		}

		public virtual string s_Pay_Status
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_Status) ? string.Empty : base.GetstringAsString(ColumnNames.Pay_Status);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_Status);
				else
					this.Pay_Status = base.SetstringAsString(ColumnNames.Pay_Status, value);
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
				
				
				public WhereParameter Pay_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_ID, Parameters.Pay_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Rent_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Rent_Id, Parameters.Rent_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pay_From
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_From, Parameters.Pay_From);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pay_To
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_To, Parameters.Pay_To);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pay_RequiredMoney
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_RequiredMoney, Parameters.Pay_RequiredMoney);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pay_Status
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_Status, Parameters.Pay_Status);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Pay_ID
		    {
				get
		        {
					if(_Pay_ID_W == null)
	        	    {
						_Pay_ID_W = TearOff.Pay_ID;
					}
					return _Pay_ID_W;
				}
			}

			public WhereParameter Rent_Id
		    {
				get
		        {
					if(_Rent_Id_W == null)
	        	    {
						_Rent_Id_W = TearOff.Rent_Id;
					}
					return _Rent_Id_W;
				}
			}

			public WhereParameter Pay_From
		    {
				get
		        {
					if(_Pay_From_W == null)
	        	    {
						_Pay_From_W = TearOff.Pay_From;
					}
					return _Pay_From_W;
				}
			}

			public WhereParameter Pay_To
		    {
				get
		        {
					if(_Pay_To_W == null)
	        	    {
						_Pay_To_W = TearOff.Pay_To;
					}
					return _Pay_To_W;
				}
			}

			public WhereParameter Pay_RequiredMoney
		    {
				get
		        {
					if(_Pay_RequiredMoney_W == null)
	        	    {
						_Pay_RequiredMoney_W = TearOff.Pay_RequiredMoney;
					}
					return _Pay_RequiredMoney_W;
				}
			}

			public WhereParameter Pay_Status
		    {
				get
		        {
					if(_Pay_Status_W == null)
	        	    {
						_Pay_Status_W = TearOff.Pay_Status;
					}
					return _Pay_Status_W;
				}
			}

			private WhereParameter _Pay_ID_W = null;
			private WhereParameter _Rent_Id_W = null;
			private WhereParameter _Pay_From_W = null;
			private WhereParameter _Pay_To_W = null;
			private WhereParameter _Pay_RequiredMoney_W = null;
			private WhereParameter _Pay_Status_W = null;

			public void WhereClauseReset()
			{
				_Pay_ID_W = null;
				_Rent_Id_W = null;
				_Pay_From_W = null;
				_Pay_To_W = null;
				_Pay_RequiredMoney_W = null;
				_Pay_Status_W = null;

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
				
				
				public AggregateParameter Pay_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_ID, Parameters.Pay_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Rent_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Rent_Id, Parameters.Rent_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pay_From
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_From, Parameters.Pay_From);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pay_To
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_To, Parameters.Pay_To);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pay_RequiredMoney
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_RequiredMoney, Parameters.Pay_RequiredMoney);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pay_Status
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_Status, Parameters.Pay_Status);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Pay_ID
		    {
				get
		        {
					if(_Pay_ID_W == null)
	        	    {
						_Pay_ID_W = TearOff.Pay_ID;
					}
					return _Pay_ID_W;
				}
			}

			public AggregateParameter Rent_Id
		    {
				get
		        {
					if(_Rent_Id_W == null)
	        	    {
						_Rent_Id_W = TearOff.Rent_Id;
					}
					return _Rent_Id_W;
				}
			}

			public AggregateParameter Pay_From
		    {
				get
		        {
					if(_Pay_From_W == null)
	        	    {
						_Pay_From_W = TearOff.Pay_From;
					}
					return _Pay_From_W;
				}
			}

			public AggregateParameter Pay_To
		    {
				get
		        {
					if(_Pay_To_W == null)
	        	    {
						_Pay_To_W = TearOff.Pay_To;
					}
					return _Pay_To_W;
				}
			}

			public AggregateParameter Pay_RequiredMoney
		    {
				get
		        {
					if(_Pay_RequiredMoney_W == null)
	        	    {
						_Pay_RequiredMoney_W = TearOff.Pay_RequiredMoney;
					}
					return _Pay_RequiredMoney_W;
				}
			}

			public AggregateParameter Pay_Status
		    {
				get
		        {
					if(_Pay_Status_W == null)
	        	    {
						_Pay_Status_W = TearOff.Pay_Status;
					}
					return _Pay_Status_W;
				}
			}

			private AggregateParameter _Pay_ID_W = null;
			private AggregateParameter _Rent_Id_W = null;
			private AggregateParameter _Pay_From_W = null;
			private AggregateParameter _Pay_To_W = null;
			private AggregateParameter _Pay_RequiredMoney_W = null;
			private AggregateParameter _Pay_Status_W = null;

			public void AggregateClauseReset()
			{
				_Pay_ID_W = null;
				_Rent_Id_W = null;
				_Pay_From_W = null;
				_Pay_To_W = null;
				_Pay_RequiredMoney_W = null;
				_Pay_Status_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblRentPaysInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblRentPaysUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblRentPaysDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Pay_ID);
			p.SourceColumn = ColumnNames.Pay_ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Pay_ID);
			p.SourceColumn = ColumnNames.Pay_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Rent_Id);
			p.SourceColumn = ColumnNames.Rent_Id;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Pay_From);
			p.SourceColumn = ColumnNames.Pay_From;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Pay_To);
			p.SourceColumn = ColumnNames.Pay_To;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Pay_RequiredMoney);
			p.SourceColumn = ColumnNames.Pay_RequiredMoney;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Pay_Status);
			p.SourceColumn = ColumnNames.Pay_Status;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
