
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
	public abstract class _TblBarcodeCountPrint : SqlClientEntity
	{
		public _TblBarcodeCountPrint()
		{
			this.QuerySource = "TblBarcodeCountPrint";
			this.MappingName = "TblBarcodeCountPrint";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblBarcodeCountPrintLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Print_ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Print_ID, Print_ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TblBarcodeCountPrintLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Print_ID
			{
				get
				{
					return new SqlParameter("@Print_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Barcode_ID
			{
				get
				{
					return new SqlParameter("@Barcode_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Title_Name
			{
				get
				{
					return new SqlParameter("@Title_Name", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter Title_Barcode
			{
				get
				{
					return new SqlParameter("@Title_Barcode", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Title_PayPrice
			{
				get
				{
					return new SqlParameter("@Title_PayPrice", SqlDbType.NVarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Print_ID = "Print_ID";
            public const string Barcode_ID = "Barcode_ID";
            public const string Title_Name = "Title_Name";
            public const string Title_Barcode = "Title_Barcode";
            public const string Title_PayPrice = "Title_PayPrice";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Print_ID] = _TblBarcodeCountPrint.PropertyNames.Print_ID;
					ht[Barcode_ID] = _TblBarcodeCountPrint.PropertyNames.Barcode_ID;
					ht[Title_Name] = _TblBarcodeCountPrint.PropertyNames.Title_Name;
					ht[Title_Barcode] = _TblBarcodeCountPrint.PropertyNames.Title_Barcode;
					ht[Title_PayPrice] = _TblBarcodeCountPrint.PropertyNames.Title_PayPrice;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Print_ID = "Print_ID";
            public const string Barcode_ID = "Barcode_ID";
            public const string Title_Name = "Title_Name";
            public const string Title_Barcode = "Title_Barcode";
            public const string Title_PayPrice = "Title_PayPrice";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Print_ID] = _TblBarcodeCountPrint.ColumnNames.Print_ID;
					ht[Barcode_ID] = _TblBarcodeCountPrint.ColumnNames.Barcode_ID;
					ht[Title_Name] = _TblBarcodeCountPrint.ColumnNames.Title_Name;
					ht[Title_Barcode] = _TblBarcodeCountPrint.ColumnNames.Title_Barcode;
					ht[Title_PayPrice] = _TblBarcodeCountPrint.ColumnNames.Title_PayPrice;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Print_ID = "s_Print_ID";
            public const string Barcode_ID = "s_Barcode_ID";
            public const string Title_Name = "s_Title_Name";
            public const string Title_Barcode = "s_Title_Barcode";
            public const string Title_PayPrice = "s_Title_PayPrice";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Print_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.Print_ID);
			}
			set
	        {
				base.Setint(ColumnNames.Print_ID, value);
			}
		}

		public virtual int Barcode_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.Barcode_ID);
			}
			set
	        {
				base.Setint(ColumnNames.Barcode_ID, value);
			}
		}

		public virtual string Title_Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Title_Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Title_Name, value);
			}
		}

		public virtual string Title_Barcode
	    {
			get
	        {
				return base.Getstring(ColumnNames.Title_Barcode);
			}
			set
	        {
				base.Setstring(ColumnNames.Title_Barcode, value);
			}
		}

		public virtual string Title_PayPrice
	    {
			get
	        {
				return base.Getstring(ColumnNames.Title_PayPrice);
			}
			set
	        {
				base.Setstring(ColumnNames.Title_PayPrice, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Print_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Print_ID) ? string.Empty : base.GetintAsString(ColumnNames.Print_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Print_ID);
				else
					this.Print_ID = base.SetintAsString(ColumnNames.Print_ID, value);
			}
		}

		public virtual string s_Barcode_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Barcode_ID) ? string.Empty : base.GetintAsString(ColumnNames.Barcode_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Barcode_ID);
				else
					this.Barcode_ID = base.SetintAsString(ColumnNames.Barcode_ID, value);
			}
		}

		public virtual string s_Title_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Title_Name) ? string.Empty : base.GetstringAsString(ColumnNames.Title_Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Title_Name);
				else
					this.Title_Name = base.SetstringAsString(ColumnNames.Title_Name, value);
			}
		}

		public virtual string s_Title_Barcode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Title_Barcode) ? string.Empty : base.GetstringAsString(ColumnNames.Title_Barcode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Title_Barcode);
				else
					this.Title_Barcode = base.SetstringAsString(ColumnNames.Title_Barcode, value);
			}
		}

		public virtual string s_Title_PayPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Title_PayPrice) ? string.Empty : base.GetstringAsString(ColumnNames.Title_PayPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Title_PayPrice);
				else
					this.Title_PayPrice = base.SetstringAsString(ColumnNames.Title_PayPrice, value);
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
				
				
				public WhereParameter Print_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Print_ID, Parameters.Print_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Barcode_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Barcode_ID, Parameters.Barcode_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Title_Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Title_Name, Parameters.Title_Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Title_Barcode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Title_Barcode, Parameters.Title_Barcode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Title_PayPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Title_PayPrice, Parameters.Title_PayPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Print_ID
		    {
				get
		        {
					if(_Print_ID_W == null)
	        	    {
						_Print_ID_W = TearOff.Print_ID;
					}
					return _Print_ID_W;
				}
			}

			public WhereParameter Barcode_ID
		    {
				get
		        {
					if(_Barcode_ID_W == null)
	        	    {
						_Barcode_ID_W = TearOff.Barcode_ID;
					}
					return _Barcode_ID_W;
				}
			}

			public WhereParameter Title_Name
		    {
				get
		        {
					if(_Title_Name_W == null)
	        	    {
						_Title_Name_W = TearOff.Title_Name;
					}
					return _Title_Name_W;
				}
			}

			public WhereParameter Title_Barcode
		    {
				get
		        {
					if(_Title_Barcode_W == null)
	        	    {
						_Title_Barcode_W = TearOff.Title_Barcode;
					}
					return _Title_Barcode_W;
				}
			}

			public WhereParameter Title_PayPrice
		    {
				get
		        {
					if(_Title_PayPrice_W == null)
	        	    {
						_Title_PayPrice_W = TearOff.Title_PayPrice;
					}
					return _Title_PayPrice_W;
				}
			}

			private WhereParameter _Print_ID_W = null;
			private WhereParameter _Barcode_ID_W = null;
			private WhereParameter _Title_Name_W = null;
			private WhereParameter _Title_Barcode_W = null;
			private WhereParameter _Title_PayPrice_W = null;

			public void WhereClauseReset()
			{
				_Print_ID_W = null;
				_Barcode_ID_W = null;
				_Title_Name_W = null;
				_Title_Barcode_W = null;
				_Title_PayPrice_W = null;

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
				
				
				public AggregateParameter Print_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Print_ID, Parameters.Print_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Barcode_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Barcode_ID, Parameters.Barcode_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Title_Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Title_Name, Parameters.Title_Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Title_Barcode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Title_Barcode, Parameters.Title_Barcode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Title_PayPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Title_PayPrice, Parameters.Title_PayPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Print_ID
		    {
				get
		        {
					if(_Print_ID_W == null)
	        	    {
						_Print_ID_W = TearOff.Print_ID;
					}
					return _Print_ID_W;
				}
			}

			public AggregateParameter Barcode_ID
		    {
				get
		        {
					if(_Barcode_ID_W == null)
	        	    {
						_Barcode_ID_W = TearOff.Barcode_ID;
					}
					return _Barcode_ID_W;
				}
			}

			public AggregateParameter Title_Name
		    {
				get
		        {
					if(_Title_Name_W == null)
	        	    {
						_Title_Name_W = TearOff.Title_Name;
					}
					return _Title_Name_W;
				}
			}

			public AggregateParameter Title_Barcode
		    {
				get
		        {
					if(_Title_Barcode_W == null)
	        	    {
						_Title_Barcode_W = TearOff.Title_Barcode;
					}
					return _Title_Barcode_W;
				}
			}

			public AggregateParameter Title_PayPrice
		    {
				get
		        {
					if(_Title_PayPrice_W == null)
	        	    {
						_Title_PayPrice_W = TearOff.Title_PayPrice;
					}
					return _Title_PayPrice_W;
				}
			}

			private AggregateParameter _Print_ID_W = null;
			private AggregateParameter _Barcode_ID_W = null;
			private AggregateParameter _Title_Name_W = null;
			private AggregateParameter _Title_Barcode_W = null;
			private AggregateParameter _Title_PayPrice_W = null;

			public void AggregateClauseReset()
			{
				_Print_ID_W = null;
				_Barcode_ID_W = null;
				_Title_Name_W = null;
				_Title_Barcode_W = null;
				_Title_PayPrice_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblBarcodeCountPrintInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Print_ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblBarcodeCountPrintUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TblBarcodeCountPrintDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Print_ID);
			p.SourceColumn = ColumnNames.Print_ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Print_ID);
			p.SourceColumn = ColumnNames.Print_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Barcode_ID);
			p.SourceColumn = ColumnNames.Barcode_ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Title_Name);
			p.SourceColumn = ColumnNames.Title_Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Title_Barcode);
			p.SourceColumn = ColumnNames.Title_Barcode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Title_PayPrice);
			p.SourceColumn = ColumnNames.Title_PayPrice;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}