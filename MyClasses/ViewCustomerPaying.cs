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
	public class ViewCustomerPaying : SqlClientEntity
	{
		public ViewCustomerPaying()
		{
			this.QuerySource = "ViewCustomerPaying";
			this.MappingName = "ViewCustomerPaying";
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
			
			public static SqlParameter Pay_ID
			{
				get
				{
					return new SqlParameter("@Pay_ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Pay_Date
			{
				get
				{
					return new SqlParameter("@Pay_Date", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Month
			{
				get
				{
					return new SqlParameter("@Month", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Year
			{
				get
				{
					return new SqlParameter("@Year", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Pay_Money
			{
				get
				{
					return new SqlParameter("@Pay_Money", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Pay_Details
			{
				get
				{
					return new SqlParameter("@Pay_Details", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter User_Id
			{
				get
				{
					return new SqlParameter("@User_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Customer_Id
			{
				get
				{
					return new SqlParameter("@Customer_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Bank_Id
			{
				get
				{
					return new SqlParameter("@Bank_Id", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Customer_Name
			{
				get
				{
					return new SqlParameter("@Customer_Name", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter User_Name
			{
				get
				{
					return new SqlParameter("@User_Name", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Bank_Name
			{
				get
				{
					return new SqlParameter("@Bank_Name", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Pay_Type
			{
				get
				{
					return new SqlParameter("@Pay_Type", SqlDbType.NVarChar, 50);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Pay_ID = "Pay_ID";
            public const string Pay_Date = "Pay_Date";
            public const string Month = "Month";
            public const string Year = "Year";
            public const string Pay_Money = "Pay_Money";
            public const string Pay_Details = "Pay_Details";
            public const string User_Id = "User_Id";
            public const string Customer_Id = "Customer_Id";
            public const string Bank_Id = "Bank_Id";
            public const string Customer_Name = "Customer_Name";
            public const string User_Name = "User_Name";
            public const string Bank_Name = "Bank_Name";
            public const string Pay_Type = "Pay_Type";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Pay_ID] = ViewCustomerPaying.PropertyNames.Pay_ID;
					ht[Pay_Date] = ViewCustomerPaying.PropertyNames.Pay_Date;
					ht[Month] = ViewCustomerPaying.PropertyNames.Month;
					ht[Year] = ViewCustomerPaying.PropertyNames.Year;
					ht[Pay_Money] = ViewCustomerPaying.PropertyNames.Pay_Money;
					ht[Pay_Details] = ViewCustomerPaying.PropertyNames.Pay_Details;
					ht[User_Id] = ViewCustomerPaying.PropertyNames.User_Id;
					ht[Customer_Id] = ViewCustomerPaying.PropertyNames.Customer_Id;
					ht[Bank_Id] = ViewCustomerPaying.PropertyNames.Bank_Id;
					ht[Customer_Name] = ViewCustomerPaying.PropertyNames.Customer_Name;
					ht[User_Name] = ViewCustomerPaying.PropertyNames.User_Name;
					ht[Bank_Name] = ViewCustomerPaying.PropertyNames.Bank_Name;
					ht[Pay_Type] = ViewCustomerPaying.PropertyNames.Pay_Type;

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
            public const string Pay_Date = "Pay_Date";
            public const string Month = "Month";
            public const string Year = "Year";
            public const string Pay_Money = "Pay_Money";
            public const string Pay_Details = "Pay_Details";
            public const string User_Id = "User_Id";
            public const string Customer_Id = "Customer_Id";
            public const string Bank_Id = "Bank_Id";
            public const string Customer_Name = "Customer_Name";
            public const string User_Name = "User_Name";
            public const string Bank_Name = "Bank_Name";
            public const string Pay_Type = "Pay_Type";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Pay_ID] = ViewCustomerPaying.ColumnNames.Pay_ID;
					ht[Pay_Date] = ViewCustomerPaying.ColumnNames.Pay_Date;
					ht[Month] = ViewCustomerPaying.ColumnNames.Month;
					ht[Year] = ViewCustomerPaying.ColumnNames.Year;
					ht[Pay_Money] = ViewCustomerPaying.ColumnNames.Pay_Money;
					ht[Pay_Details] = ViewCustomerPaying.ColumnNames.Pay_Details;
					ht[User_Id] = ViewCustomerPaying.ColumnNames.User_Id;
					ht[Customer_Id] = ViewCustomerPaying.ColumnNames.Customer_Id;
					ht[Bank_Id] = ViewCustomerPaying.ColumnNames.Bank_Id;
					ht[Customer_Name] = ViewCustomerPaying.ColumnNames.Customer_Name;
					ht[User_Name] = ViewCustomerPaying.ColumnNames.User_Name;
					ht[Bank_Name] = ViewCustomerPaying.ColumnNames.Bank_Name;
					ht[Pay_Type] = ViewCustomerPaying.ColumnNames.Pay_Type;

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
            public const string Pay_Date = "s_Pay_Date";
            public const string Month = "s_Month";
            public const string Year = "s_Year";
            public const string Pay_Money = "s_Pay_Money";
            public const string Pay_Details = "s_Pay_Details";
            public const string User_Id = "s_User_Id";
            public const string Customer_Id = "s_Customer_Id";
            public const string Bank_Id = "s_Bank_Id";
            public const string Customer_Name = "s_Customer_Name";
            public const string User_Name = "s_User_Name";
            public const string Bank_Name = "s_Bank_Name";
            public const string Pay_Type = "s_Pay_Type";

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

		public virtual DateTime Pay_Date
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Pay_Date);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Pay_Date, value);
			}
		}

		public virtual int Month
	    {
			get
	        {
				return base.Getint(ColumnNames.Month);
			}
			set
	        {
				base.Setint(ColumnNames.Month, value);
			}
		}

		public virtual int Year
	    {
			get
	        {
				return base.Getint(ColumnNames.Year);
			}
			set
	        {
				base.Setint(ColumnNames.Year, value);
			}
		}

		public virtual double Pay_Money
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Pay_Money);
			}
			set
	        {
				base.Setdouble(ColumnNames.Pay_Money, value);
			}
		}

		public virtual string Pay_Details
	    {
			get
	        {
				return base.Getstring(ColumnNames.Pay_Details);
			}
			set
	        {
				base.Setstring(ColumnNames.Pay_Details, value);
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

		public virtual int Customer_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.Customer_Id);
			}
			set
	        {
				base.Setint(ColumnNames.Customer_Id, value);
			}
		}

		public virtual int Bank_Id
	    {
			get
	        {
				return base.Getint(ColumnNames.Bank_Id);
			}
			set
	        {
				base.Setint(ColumnNames.Bank_Id, value);
			}
		}

		public virtual string Customer_Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Customer_Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Customer_Name, value);
			}
		}

		public virtual string User_Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.User_Name);
			}
			set
	        {
				base.Setstring(ColumnNames.User_Name, value);
			}
		}

		public virtual string Bank_Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Bank_Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Bank_Name, value);
			}
		}

		public virtual string Pay_Type
	    {
			get
	        {
				return base.Getstring(ColumnNames.Pay_Type);
			}
			set
	        {
				base.Setstring(ColumnNames.Pay_Type, value);
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

		public virtual string s_Pay_Date
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_Date) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Pay_Date);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_Date);
				else
					this.Pay_Date = base.SetDateTimeAsString(ColumnNames.Pay_Date, value);
			}
		}

		public virtual string s_Month
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Month) ? string.Empty : base.GetintAsString(ColumnNames.Month);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Month);
				else
					this.Month = base.SetintAsString(ColumnNames.Month, value);
			}
		}

		public virtual string s_Year
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Year) ? string.Empty : base.GetintAsString(ColumnNames.Year);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Year);
				else
					this.Year = base.SetintAsString(ColumnNames.Year, value);
			}
		}

		public virtual string s_Pay_Money
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_Money) ? string.Empty : base.GetdoubleAsString(ColumnNames.Pay_Money);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_Money);
				else
					this.Pay_Money = base.SetdoubleAsString(ColumnNames.Pay_Money, value);
			}
		}

		public virtual string s_Pay_Details
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_Details) ? string.Empty : base.GetstringAsString(ColumnNames.Pay_Details);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_Details);
				else
					this.Pay_Details = base.SetstringAsString(ColumnNames.Pay_Details, value);
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

		public virtual string s_Customer_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Customer_Id) ? string.Empty : base.GetintAsString(ColumnNames.Customer_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Customer_Id);
				else
					this.Customer_Id = base.SetintAsString(ColumnNames.Customer_Id, value);
			}
		}

		public virtual string s_Bank_Id
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bank_Id) ? string.Empty : base.GetintAsString(ColumnNames.Bank_Id);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bank_Id);
				else
					this.Bank_Id = base.SetintAsString(ColumnNames.Bank_Id, value);
			}
		}

		public virtual string s_Customer_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Customer_Name) ? string.Empty : base.GetstringAsString(ColumnNames.Customer_Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Customer_Name);
				else
					this.Customer_Name = base.SetstringAsString(ColumnNames.Customer_Name, value);
			}
		}

		public virtual string s_User_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.User_Name) ? string.Empty : base.GetstringAsString(ColumnNames.User_Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.User_Name);
				else
					this.User_Name = base.SetstringAsString(ColumnNames.User_Name, value);
			}
		}

		public virtual string s_Bank_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Bank_Name) ? string.Empty : base.GetstringAsString(ColumnNames.Bank_Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Bank_Name);
				else
					this.Bank_Name = base.SetstringAsString(ColumnNames.Bank_Name, value);
			}
		}

		public virtual string s_Pay_Type
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pay_Type) ? string.Empty : base.GetstringAsString(ColumnNames.Pay_Type);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pay_Type);
				else
					this.Pay_Type = base.SetstringAsString(ColumnNames.Pay_Type, value);
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

				public WhereParameter Pay_Date
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_Date, Parameters.Pay_Date);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Month
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Month, Parameters.Month);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Year
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Year, Parameters.Year);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pay_Money
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_Money, Parameters.Pay_Money);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pay_Details
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_Details, Parameters.Pay_Details);
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

				public WhereParameter Customer_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Customer_Id, Parameters.Customer_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Bank_Id
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bank_Id, Parameters.Bank_Id);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Customer_Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Customer_Name, Parameters.Customer_Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter User_Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.User_Name, Parameters.User_Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Bank_Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Bank_Name, Parameters.Bank_Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pay_Type
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pay_Type, Parameters.Pay_Type);
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

			public WhereParameter Pay_Date
		    {
				get
		        {
					if(_Pay_Date_W == null)
	        	    {
						_Pay_Date_W = TearOff.Pay_Date;
					}
					return _Pay_Date_W;
				}
			}

			public WhereParameter Month
		    {
				get
		        {
					if(_Month_W == null)
	        	    {
						_Month_W = TearOff.Month;
					}
					return _Month_W;
				}
			}

			public WhereParameter Year
		    {
				get
		        {
					if(_Year_W == null)
	        	    {
						_Year_W = TearOff.Year;
					}
					return _Year_W;
				}
			}

			public WhereParameter Pay_Money
		    {
				get
		        {
					if(_Pay_Money_W == null)
	        	    {
						_Pay_Money_W = TearOff.Pay_Money;
					}
					return _Pay_Money_W;
				}
			}

			public WhereParameter Pay_Details
		    {
				get
		        {
					if(_Pay_Details_W == null)
	        	    {
						_Pay_Details_W = TearOff.Pay_Details;
					}
					return _Pay_Details_W;
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

			public WhereParameter Customer_Id
		    {
				get
		        {
					if(_Customer_Id_W == null)
	        	    {
						_Customer_Id_W = TearOff.Customer_Id;
					}
					return _Customer_Id_W;
				}
			}

			public WhereParameter Bank_Id
		    {
				get
		        {
					if(_Bank_Id_W == null)
	        	    {
						_Bank_Id_W = TearOff.Bank_Id;
					}
					return _Bank_Id_W;
				}
			}

			public WhereParameter Customer_Name
		    {
				get
		        {
					if(_Customer_Name_W == null)
	        	    {
						_Customer_Name_W = TearOff.Customer_Name;
					}
					return _Customer_Name_W;
				}
			}

			public WhereParameter User_Name
		    {
				get
		        {
					if(_User_Name_W == null)
	        	    {
						_User_Name_W = TearOff.User_Name;
					}
					return _User_Name_W;
				}
			}

			public WhereParameter Bank_Name
		    {
				get
		        {
					if(_Bank_Name_W == null)
	        	    {
						_Bank_Name_W = TearOff.Bank_Name;
					}
					return _Bank_Name_W;
				}
			}

			public WhereParameter Pay_Type
		    {
				get
		        {
					if(_Pay_Type_W == null)
	        	    {
						_Pay_Type_W = TearOff.Pay_Type;
					}
					return _Pay_Type_W;
				}
			}

			private WhereParameter _Pay_ID_W = null;
			private WhereParameter _Pay_Date_W = null;
			private WhereParameter _Month_W = null;
			private WhereParameter _Year_W = null;
			private WhereParameter _Pay_Money_W = null;
			private WhereParameter _Pay_Details_W = null;
			private WhereParameter _User_Id_W = null;
			private WhereParameter _Customer_Id_W = null;
			private WhereParameter _Bank_Id_W = null;
			private WhereParameter _Customer_Name_W = null;
			private WhereParameter _User_Name_W = null;
			private WhereParameter _Bank_Name_W = null;
			private WhereParameter _Pay_Type_W = null;

			public void WhereClauseReset()
			{
				_Pay_ID_W = null;
				_Pay_Date_W = null;
				_Month_W = null;
				_Year_W = null;
				_Pay_Money_W = null;
				_Pay_Details_W = null;
				_User_Id_W = null;
				_Customer_Id_W = null;
				_Bank_Id_W = null;
				_Customer_Name_W = null;
				_User_Name_W = null;
				_Bank_Name_W = null;
				_Pay_Type_W = null;

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

				public AggregateParameter Pay_Date
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_Date, Parameters.Pay_Date);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Month
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Month, Parameters.Month);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Year
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Year, Parameters.Year);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pay_Money
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_Money, Parameters.Pay_Money);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pay_Details
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_Details, Parameters.Pay_Details);
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

				public AggregateParameter Customer_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Customer_Id, Parameters.Customer_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Bank_Id
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bank_Id, Parameters.Bank_Id);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Customer_Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Customer_Name, Parameters.Customer_Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter User_Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.User_Name, Parameters.User_Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Bank_Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Bank_Name, Parameters.Bank_Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pay_Type
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pay_Type, Parameters.Pay_Type);
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

			public AggregateParameter Pay_Date
		    {
				get
		        {
					if(_Pay_Date_W == null)
	        	    {
						_Pay_Date_W = TearOff.Pay_Date;
					}
					return _Pay_Date_W;
				}
			}

			public AggregateParameter Month
		    {
				get
		        {
					if(_Month_W == null)
	        	    {
						_Month_W = TearOff.Month;
					}
					return _Month_W;
				}
			}

			public AggregateParameter Year
		    {
				get
		        {
					if(_Year_W == null)
	        	    {
						_Year_W = TearOff.Year;
					}
					return _Year_W;
				}
			}

			public AggregateParameter Pay_Money
		    {
				get
		        {
					if(_Pay_Money_W == null)
	        	    {
						_Pay_Money_W = TearOff.Pay_Money;
					}
					return _Pay_Money_W;
				}
			}

			public AggregateParameter Pay_Details
		    {
				get
		        {
					if(_Pay_Details_W == null)
	        	    {
						_Pay_Details_W = TearOff.Pay_Details;
					}
					return _Pay_Details_W;
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

			public AggregateParameter Customer_Id
		    {
				get
		        {
					if(_Customer_Id_W == null)
	        	    {
						_Customer_Id_W = TearOff.Customer_Id;
					}
					return _Customer_Id_W;
				}
			}

			public AggregateParameter Bank_Id
		    {
				get
		        {
					if(_Bank_Id_W == null)
	        	    {
						_Bank_Id_W = TearOff.Bank_Id;
					}
					return _Bank_Id_W;
				}
			}

			public AggregateParameter Customer_Name
		    {
				get
		        {
					if(_Customer_Name_W == null)
	        	    {
						_Customer_Name_W = TearOff.Customer_Name;
					}
					return _Customer_Name_W;
				}
			}

			public AggregateParameter User_Name
		    {
				get
		        {
					if(_User_Name_W == null)
	        	    {
						_User_Name_W = TearOff.User_Name;
					}
					return _User_Name_W;
				}
			}

			public AggregateParameter Bank_Name
		    {
				get
		        {
					if(_Bank_Name_W == null)
	        	    {
						_Bank_Name_W = TearOff.Bank_Name;
					}
					return _Bank_Name_W;
				}
			}

			public AggregateParameter Pay_Type
		    {
				get
		        {
					if(_Pay_Type_W == null)
	        	    {
						_Pay_Type_W = TearOff.Pay_Type;
					}
					return _Pay_Type_W;
				}
			}

			private AggregateParameter _Pay_ID_W = null;
			private AggregateParameter _Pay_Date_W = null;
			private AggregateParameter _Month_W = null;
			private AggregateParameter _Year_W = null;
			private AggregateParameter _Pay_Money_W = null;
			private AggregateParameter _Pay_Details_W = null;
			private AggregateParameter _User_Id_W = null;
			private AggregateParameter _Customer_Id_W = null;
			private AggregateParameter _Bank_Id_W = null;
			private AggregateParameter _Customer_Name_W = null;
			private AggregateParameter _User_Name_W = null;
			private AggregateParameter _Bank_Name_W = null;
			private AggregateParameter _Pay_Type_W = null;

			public void AggregateClauseReset()
			{
				_Pay_ID_W = null;
				_Pay_Date_W = null;
				_Month_W = null;
				_Year_W = null;
				_Pay_Money_W = null;
				_Pay_Details_W = null;
				_User_Id_W = null;
				_Customer_Id_W = null;
				_Bank_Id_W = null;
				_Customer_Name_W = null;
				_User_Name_W = null;
				_Bank_Name_W = null;
				_Pay_Type_W = null;

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