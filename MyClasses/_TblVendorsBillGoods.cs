
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
	public abstract class _TblVendorsBillGoods : SqlClientEntity
	{
		public _TblVendorsBillGoods()
		{
			this.QuerySource = "TblVendorsBillGoods";
			this.MappingName = "TblVendorsBillGoods";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblVendorsBillGoodsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Good_id)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Good_id, Good_id);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblVendorsBillGoodsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Good_id
			{
				get
				{
					return new SqlParameter("@Good_id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Bill_id
			{
				get
				{
					return new SqlParameter("@Bill_id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Barcode_Id
			{
				get
				{
					return new SqlParameter("@Barcode_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Good_Count
			{
				get
				{
					return new SqlParameter("@Good_Count", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Good_Price
			{
				get
				{
					return new SqlParameter("@Good_Price", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Good_Total
			{
				get
				{
					return new SqlParameter("@Good_Total", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Good_FreeBones
			{
				get
				{
					return new SqlParameter("@Good_FreeBones", SqlDbType.Float, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Good_id = "Good_id";
            public const string Bill_id = "Bill_id";
            public const string Barcode_Id = "Barcode_Id";
            public const string Good_Count = "Good_Count";
            public const string Good_Price = "Good_Price";
            public const string Good_Total = "Good_Total";
            public const string Good_FreeBones = "Good_FreeBones";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Good_id] = _TblVendorsBillGoods.PropertyNames.Good_id;
					ht[Bill_id] = _TblVendorsBillGoods.PropertyNames.Bill_id;
					ht[Barcode_Id] = _TblVendorsBillGoods.PropertyNames.Barcode_Id;
					ht[Good_Count] = _TblVendorsBillGoods.PropertyNames.Good_Count;
					ht[Good_Price] = _TblVendorsBillGoods.PropertyNames.Good_Price;
					ht[Good_Total] = _TblVendorsBillGoods.PropertyNames.Good_Total;
					ht[Good_FreeBones] = _TblVendorsBillGoods.PropertyNames.Good_FreeBones;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Good_id = "Good_id";
            public const string Bill_id = "Bill_id";
            public const string Barcode_Id = "Barcode_Id";
            public const string Good_Count = "Good_Count";
            public const string Good_Price = "Good_Price";
            public const string Good_Total = "Good_Total";
            public const string Good_FreeBones = "Good_FreeBones";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Good_id] = _TblVendorsBillGoods.ColumnNames.Good_id;
					ht[Bill_id] = _TblVendorsBillGoods.ColumnNames.Bill_id;
					ht[Barcode_Id] = _TblVendorsBillGoods.ColumnNames.Barcode_Id;
					ht[Good_Count] = _TblVendorsBillGoods.ColumnNames.Good_Count;
					ht[Good_Price] = _TblVendorsBillGoods.ColumnNames.Good_Price;
					ht[Good_Total] = _TblVendorsBillGoods.ColumnNames.Good_Total;
					ht[Good_FreeBones] = _TblVendorsBillGoods.ColumnNames.Good_FreeBones;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Good_id = "s_Good_id";
            public const string Bill_id = "s_Bill_id";
            public const string Barcode_Id = "s_Barcode_Id";
            public const string Good_Count = "s_Good_Count";
            public const string Good_Price = "s_Good_Price";
            public const string Good_Total = "s_Good_Total";
            public const string Good_FreeBones = "s_Good_FreeBones";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Good_id
	    {
			get
	        {
				return base.Getint(ColumnNames.Good_id);
			}
			set
	        {
				base.Setint(ColumnNames.Good_id, value);
			}
		}

		public virtual int Bill_id
	    {
			get
	        {
				return base.Getint(ColumnNames.Bill_id);
			}
			set
	        {
				base.Setint(ColumnNames.Bill_id, value);
			}
		}

		public virtual int Barcode_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.Barcode_Id);
			}
			set
	        {
				base.Setint(ColumnNames.Barcode_Id, value);
			}
		}

		public virtual double Good_Count
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Good_Count);
			}
			set
	        {
				base.Setdouble(ColumnNames.Good_Count, value);
			}
		}

		public virtual double Good_Price
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Good_Price);
			}
			set
	        {
				base.Setdouble(ColumnNames.Good_Price, value);
			}
		}

		public virtual double Good_Total
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Good_Total);
			}
		}

		public virtual double Good_FreeBones
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Good_FreeBones);
			}
			set
	        {
				base.Setdouble(ColumnNames.Good_FreeBones, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Good_id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Good_id) ? string.Empty : base.GetintAsString(ColumnNames.Good_id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Good_id);
				else
					this.Good_id = base.SetintAsString(ColumnNames.Good_id, value);
			}
		}

		public virtual string s_Bill_id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bill_id) ? string.Empty : base.GetintAsString(ColumnNames.Bill_id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bill_id);
				else
					this.Bill_id = base.SetintAsString(ColumnNames.Bill_id, value);
			}
		}

		public virtual string s_Barcode_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Barcode_Id) ? string.Empty : base.GetintAsString(ColumnNames.Barcode_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Barcode_Id);
				else
					this.Barcode_Id = base.SetintAsString(ColumnNames.Barcode_Id, value);
			}
		}

		public virtual string s_Good_Count
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Good_Count) ? string.Empty : base.GetdoubleAsString(ColumnNames.Good_Count);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Good_Count);
				else
					this.Good_Count = base.SetdoubleAsString(ColumnNames.Good_Count, value);
			}
		}

		public virtual string s_Good_Price
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Good_Price) ? string.Empty : base.GetdoubleAsString(ColumnNames.Good_Price);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Good_Price);
				else
					this.Good_Price = base.SetdoubleAsString(ColumnNames.Good_Price, value);
			}
		}

		public virtual string s_Good_Total
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Good_Total) ? string.Empty : base.GetdoubleAsString(ColumnNames.Good_Total);
			}
		}

		public virtual string s_Good_FreeBones
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Good_FreeBones) ? string.Empty : base.GetdoubleAsString(ColumnNames.Good_FreeBones);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Good_FreeBones);
				else
					this.Good_FreeBones = base.SetdoubleAsString(ColumnNames.Good_FreeBones, value);
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
				
				
				public WhereParameter Good_id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Good_id, Parameters.Good_id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Bill_id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bill_id, Parameters.Bill_id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Barcode_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Barcode_Id, Parameters.Barcode_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Good_Count
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Good_Count, Parameters.Good_Count);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Good_Price
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Good_Price, Parameters.Good_Price);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Good_Total
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Good_Total, Parameters.Good_Total);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Good_FreeBones
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Good_FreeBones, Parameters.Good_FreeBones);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Good_id
		    {
				get
		        {
					if(_Good_id_W == null)
	        	    {
						_Good_id_W = TearOff.Good_id;
					}
					return _Good_id_W;
				}
			}

			public WhereParameter Bill_id
		    {
				get
		        {
					if(_Bill_id_W == null)
	        	    {
						_Bill_id_W = TearOff.Bill_id;
					}
					return _Bill_id_W;
				}
			}

			public WhereParameter Barcode_Id
		    {
				get
		        {
					if(_Barcode_Id_W == null)
	        	    {
						_Barcode_Id_W = TearOff.Barcode_Id;
					}
					return _Barcode_Id_W;
				}
			}

			public WhereParameter Good_Count
		    {
				get
		        {
					if(_Good_Count_W == null)
	        	    {
						_Good_Count_W = TearOff.Good_Count;
					}
					return _Good_Count_W;
				}
			}

			public WhereParameter Good_Price
		    {
				get
		        {
					if(_Good_Price_W == null)
	        	    {
						_Good_Price_W = TearOff.Good_Price;
					}
					return _Good_Price_W;
				}
			}

			public WhereParameter Good_Total
		    {
				get
		        {
					if(_Good_Total_W == null)
	        	    {
						_Good_Total_W = TearOff.Good_Total;
					}
					return _Good_Total_W;
				}
			}

			public WhereParameter Good_FreeBones
		    {
				get
		        {
					if(_Good_FreeBones_W == null)
	        	    {
						_Good_FreeBones_W = TearOff.Good_FreeBones;
					}
					return _Good_FreeBones_W;
				}
			}

			private WhereParameter _Good_id_W = null;
			private WhereParameter _Bill_id_W = null;
			private WhereParameter _Barcode_Id_W = null;
			private WhereParameter _Good_Count_W = null;
			private WhereParameter _Good_Price_W = null;
			private WhereParameter _Good_Total_W = null;
			private WhereParameter _Good_FreeBones_W = null;

			public void WhereClauseReset()
			{
				_Good_id_W = null;
				_Bill_id_W = null;
				_Barcode_Id_W = null;
				_Good_Count_W = null;
				_Good_Price_W = null;
				_Good_Total_W = null;
				_Good_FreeBones_W = null;

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
				
				
				public AggregateParameter Good_id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Good_id, Parameters.Good_id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Bill_id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bill_id, Parameters.Bill_id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Barcode_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Barcode_Id, Parameters.Barcode_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Good_Count
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Good_Count, Parameters.Good_Count);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Good_Price
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Good_Price, Parameters.Good_Price);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Good_Total
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Good_Total, Parameters.Good_Total);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Good_FreeBones
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Good_FreeBones, Parameters.Good_FreeBones);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Good_id
		    {
				get
		        {
					if(_Good_id_W == null)
	        	    {
						_Good_id_W = TearOff.Good_id;
					}
					return _Good_id_W;
				}
			}

			public AggregateParameter Bill_id
		    {
				get
		        {
					if(_Bill_id_W == null)
	        	    {
						_Bill_id_W = TearOff.Bill_id;
					}
					return _Bill_id_W;
				}
			}

			public AggregateParameter Barcode_Id
		    {
				get
		        {
					if(_Barcode_Id_W == null)
	        	    {
						_Barcode_Id_W = TearOff.Barcode_Id;
					}
					return _Barcode_Id_W;
				}
			}

			public AggregateParameter Good_Count
		    {
				get
		        {
					if(_Good_Count_W == null)
	        	    {
						_Good_Count_W = TearOff.Good_Count;
					}
					return _Good_Count_W;
				}
			}

			public AggregateParameter Good_Price
		    {
				get
		        {
					if(_Good_Price_W == null)
	        	    {
						_Good_Price_W = TearOff.Good_Price;
					}
					return _Good_Price_W;
				}
			}

			public AggregateParameter Good_Total
		    {
				get
		        {
					if(_Good_Total_W == null)
	        	    {
						_Good_Total_W = TearOff.Good_Total;
					}
					return _Good_Total_W;
				}
			}

			public AggregateParameter Good_FreeBones
		    {
				get
		        {
					if(_Good_FreeBones_W == null)
	        	    {
						_Good_FreeBones_W = TearOff.Good_FreeBones;
					}
					return _Good_FreeBones_W;
				}
			}

			private AggregateParameter _Good_id_W = null;
			private AggregateParameter _Bill_id_W = null;
			private AggregateParameter _Barcode_Id_W = null;
			private AggregateParameter _Good_Count_W = null;
			private AggregateParameter _Good_Price_W = null;
			private AggregateParameter _Good_Total_W = null;
			private AggregateParameter _Good_FreeBones_W = null;

			public void AggregateClauseReset()
			{
				_Good_id_W = null;
				_Bill_id_W = null;
				_Barcode_Id_W = null;
				_Good_Count_W = null;
				_Good_Price_W = null;
				_Good_Total_W = null;
				_Good_FreeBones_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblVendorsBillGoodsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Good_id.ParameterName];
			p.Direction = ParameterDirection.Output;
			p = cmd.Parameters[Parameters.Good_Total.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblVendorsBillGoodsUpdate]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Good_Total.ParameterName];
			p.Direction = ParameterDirection.Output;
      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblVendorsBillGoodsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Good_id);
			p.SourceColumn = ColumnNames.Good_id;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Good_id);
			p.SourceColumn = ColumnNames.Good_id;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Bill_id);
			p.SourceColumn = ColumnNames.Bill_id;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Barcode_Id);
			p.SourceColumn = ColumnNames.Barcode_Id;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Good_Count);
			p.SourceColumn = ColumnNames.Good_Count;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Good_Price);
			p.SourceColumn = ColumnNames.Good_Price;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Good_Total);
			p.SourceColumn = ColumnNames.Good_Total;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Good_FreeBones);
			p.SourceColumn = ColumnNames.Good_FreeBones;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
