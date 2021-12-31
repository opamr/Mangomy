/*
'===============================================================================
'  Generated From - CSharp_dOOdads_View.vbgen
'
'  The supporting base class SqlClientEntity is in the 
'  Architecture directory in "dOOdads".
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
	public class ViewStoreReviewDetails : SqlClientEntity
	{
		public ViewStoreReviewDetails()
		{
			this.QuerySource = "ViewStoreReviewDetails";
			this.MappingName = "ViewStoreReviewDetails";
		}	
	
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			return base.Query.Load();
		}
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
	
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Titel_Id
			{
				get
				{
					return new SqlParameter("@Titel_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Detail_ID
			{
				get
				{
					return new SqlParameter("@Detail_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Summary_Id
			{
				get
				{
					return new SqlParameter("@Summary_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Detail_Count
			{
				get
				{
					return new SqlParameter("@Detail_Count", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter User_Id
			{
				get
				{
					return new SqlParameter("@User_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Barcode_Id
			{
				get
				{
					return new SqlParameter("@Barcode_Id", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Titel_Id = "Titel_Id";
            public const string Detail_ID = "Detail_ID";
            public const string Summary_Id = "Summary_Id";
            public const string Detail_Count = "Detail_Count";
            public const string User_Id = "User_Id";
            public const string Barcode_Id = "Barcode_Id";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Titel_Id] = ViewStoreReviewDetails.PropertyNames.Titel_Id;
					ht[Detail_ID] = ViewStoreReviewDetails.PropertyNames.Detail_ID;
					ht[Summary_Id] = ViewStoreReviewDetails.PropertyNames.Summary_Id;
					ht[Detail_Count] = ViewStoreReviewDetails.PropertyNames.Detail_Count;
					ht[User_Id] = ViewStoreReviewDetails.PropertyNames.User_Id;
					ht[Barcode_Id] = ViewStoreReviewDetails.PropertyNames.Barcode_Id;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Titel_Id = "Titel_Id";
            public const string Detail_ID = "Detail_ID";
            public const string Summary_Id = "Summary_Id";
            public const string Detail_Count = "Detail_Count";
            public const string User_Id = "User_Id";
            public const string Barcode_Id = "Barcode_Id";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Titel_Id] = ViewStoreReviewDetails.ColumnNames.Titel_Id;
					ht[Detail_ID] = ViewStoreReviewDetails.ColumnNames.Detail_ID;
					ht[Summary_Id] = ViewStoreReviewDetails.ColumnNames.Summary_Id;
					ht[Detail_Count] = ViewStoreReviewDetails.ColumnNames.Detail_Count;
					ht[User_Id] = ViewStoreReviewDetails.ColumnNames.User_Id;
					ht[Barcode_Id] = ViewStoreReviewDetails.ColumnNames.Barcode_Id;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Titel_Id = "s_Titel_Id";
            public const string Detail_ID = "s_Detail_ID";
            public const string Summary_Id = "s_Summary_Id";
            public const string Detail_Count = "s_Detail_Count";
            public const string User_Id = "s_User_Id";
            public const string Barcode_Id = "s_Barcode_Id";

		}
		#endregion	
		
		#region Properties
			public virtual int Titel_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.Titel_Id);
			}
			set
	        {
				base.Setint(ColumnNames.Titel_Id, value);
			}
		}

		public virtual int Detail_ID
	    {
			get
	        {
				return base.Getint(ColumnNames.Detail_ID);
			}
			set
	        {
				base.Setint(ColumnNames.Detail_ID, value);
			}
		}

		public virtual int Summary_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.Summary_Id);
			}
			set
	        {
				base.Setint(ColumnNames.Summary_Id, value);
			}
		}

		public virtual double Detail_Count
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Detail_Count);
			}
			set
	        {
				base.Setdouble(ColumnNames.Detail_Count, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_Titel_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Titel_Id) ? string.Empty : base.GetintAsString(ColumnNames.Titel_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Titel_Id);
				else
					this.Titel_Id = base.SetintAsString(ColumnNames.Titel_Id, value);
			}
		}

		public virtual string s_Detail_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Detail_ID) ? string.Empty : base.GetintAsString(ColumnNames.Detail_ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Detail_ID);
				else
					this.Detail_ID = base.SetintAsString(ColumnNames.Detail_ID, value);
			}
		}

		public virtual string s_Summary_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Summary_Id) ? string.Empty : base.GetintAsString(ColumnNames.Summary_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Summary_Id);
				else
					this.Summary_Id = base.SetintAsString(ColumnNames.Summary_Id, value);
			}
		}

		public virtual string s_Detail_Count
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Detail_Count) ? string.Empty : base.GetdoubleAsString(ColumnNames.Detail_Count);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Detail_Count);
				else
					this.Detail_Count = base.SetdoubleAsString(ColumnNames.Detail_Count, value);
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
				
				
				public WhereParameter Titel_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Titel_Id, Parameters.Titel_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Detail_ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Detail_ID, Parameters.Detail_ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Summary_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Summary_Id, Parameters.Summary_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Detail_Count
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Detail_Count, Parameters.Detail_Count);
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

				public WhereParameter Barcode_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Barcode_Id, Parameters.Barcode_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Titel_Id
		    {
				get
		        {
					if(_Titel_Id_W == null)
	        	    {
						_Titel_Id_W = TearOff.Titel_Id;
					}
					return _Titel_Id_W;
				}
			}

			public WhereParameter Detail_ID
		    {
				get
		        {
					if(_Detail_ID_W == null)
	        	    {
						_Detail_ID_W = TearOff.Detail_ID;
					}
					return _Detail_ID_W;
				}
			}

			public WhereParameter Summary_Id
		    {
				get
		        {
					if(_Summary_Id_W == null)
	        	    {
						_Summary_Id_W = TearOff.Summary_Id;
					}
					return _Summary_Id_W;
				}
			}

			public WhereParameter Detail_Count
		    {
				get
		        {
					if(_Detail_Count_W == null)
	        	    {
						_Detail_Count_W = TearOff.Detail_Count;
					}
					return _Detail_Count_W;
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

			private WhereParameter _Titel_Id_W = null;
			private WhereParameter _Detail_ID_W = null;
			private WhereParameter _Summary_Id_W = null;
			private WhereParameter _Detail_Count_W = null;
			private WhereParameter _User_Id_W = null;
			private WhereParameter _Barcode_Id_W = null;

			public void WhereClauseReset()
			{
				_Titel_Id_W = null;
				_Detail_ID_W = null;
				_Summary_Id_W = null;
				_Detail_Count_W = null;
				_User_Id_W = null;
				_Barcode_Id_W = null;

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
				
				
				public AggregateParameter Titel_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Titel_Id, Parameters.Titel_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Detail_ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Detail_ID, Parameters.Detail_ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Summary_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Summary_Id, Parameters.Summary_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Detail_Count
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Detail_Count, Parameters.Detail_Count);
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

				public AggregateParameter Barcode_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Barcode_Id, Parameters.Barcode_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Titel_Id
		    {
				get
		        {
					if(_Titel_Id_W == null)
	        	    {
						_Titel_Id_W = TearOff.Titel_Id;
					}
					return _Titel_Id_W;
				}
			}

			public AggregateParameter Detail_ID
		    {
				get
		        {
					if(_Detail_ID_W == null)
	        	    {
						_Detail_ID_W = TearOff.Detail_ID;
					}
					return _Detail_ID_W;
				}
			}

			public AggregateParameter Summary_Id
		    {
				get
		        {
					if(_Summary_Id_W == null)
	        	    {
						_Summary_Id_W = TearOff.Summary_Id;
					}
					return _Summary_Id_W;
				}
			}

			public AggregateParameter Detail_Count
		    {
				get
		        {
					if(_Detail_Count_W == null)
	        	    {
						_Detail_Count_W = TearOff.Detail_Count;
					}
					return _Detail_Count_W;
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

			private AggregateParameter _Titel_Id_W = null;
			private AggregateParameter _Detail_ID_W = null;
			private AggregateParameter _Summary_Id_W = null;
			private AggregateParameter _Detail_Count_W = null;
			private AggregateParameter _User_Id_W = null;
			private AggregateParameter _Barcode_Id_W = null;

			public void AggregateClauseReset()
			{
				_Titel_Id_W = null;
				_Detail_ID_W = null;
				_Summary_Id_W = null;
				_Detail_Count_W = null;
				_User_Id_W = null;
				_Barcode_Id_W = null;

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
			return null;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
			return null;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
			return null;
		}
	}
}