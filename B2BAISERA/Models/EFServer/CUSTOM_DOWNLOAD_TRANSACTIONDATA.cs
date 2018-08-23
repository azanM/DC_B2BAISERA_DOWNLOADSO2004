//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace B2BAISERA.Models.EFServer
{
    public partial class CUSTOM_DOWNLOAD_TRANSACTIONDATA
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual int TransactionID
        {
            get { return _transactionID; }
            set
            {
                if (_transactionID != value)
                {
                    if (CUSTOM_DOWNLOAD_TRANSACTION != null && CUSTOM_DOWNLOAD_TRANSACTION.ID != value)
                    {
                        CUSTOM_DOWNLOAD_TRANSACTION = null;
                    }
                    _transactionID = value;
                }
            }
        }
        private int _transactionID;
    
        public virtual string TransGUID
        {
            get;
            set;
        }
    
        public virtual string DocumentNumber
        {
            get;
            set;
        }
    
        public virtual string FileType
        {
            get;
            set;
        }
    
        public virtual string IPAddress
        {
            get;
            set;
        }
    
        public virtual string DestinationUser
        {
            get;
            set;
        }
    
        public virtual string Key1
        {
            get;
            set;
        }
    
        public virtual string Key2
        {
            get;
            set;
        }
    
        public virtual string Key3
        {
            get;
            set;
        }
    
        public virtual Nullable<int> DataLength
        {
            get;
            set;
        }
    
        public virtual string CreatedWho
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> CreatedWhen
        {
            get;
            set;
        }
    
        public virtual string ChangedWho
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> ChangedWhen
        {
            get;
            set;
        }
    
        public virtual Nullable<int> AIID
        {
            get;
            set;
        }
    
        public virtual string TransStatus
        {
            get;
            set;
        }
    
        public virtual string LogMessage
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual CUSTOM_DOWNLOAD_TRANSACTION CUSTOM_DOWNLOAD_TRANSACTION
        {
            get { return _cUSTOM_DOWNLOAD_TRANSACTION; }
            set
            {
                if (!ReferenceEquals(_cUSTOM_DOWNLOAD_TRANSACTION, value))
                {
                    var previousValue = _cUSTOM_DOWNLOAD_TRANSACTION;
                    _cUSTOM_DOWNLOAD_TRANSACTION = value;
                    FixupCUSTOM_DOWNLOAD_TRANSACTION(previousValue);
                }
            }
        }
        private CUSTOM_DOWNLOAD_TRANSACTION _cUSTOM_DOWNLOAD_TRANSACTION;
    
        public virtual ICollection<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL> CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL
        {
            get
            {
                if (_cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL == null)
                {
                    var newCollection = new FixupCollection<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL>();
                    newCollection.CollectionChanged += FixupCUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL;
                    _cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL = newCollection;
                }
                return _cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL;
            }
            set
            {
                if (!ReferenceEquals(_cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL, value))
                {
                    var previousValue = _cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL as FixupCollection<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL;
                    }
                    _cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL = value;
                    var newValue = value as FixupCollection<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL;
                    }
                }
            }
        }
        private ICollection<CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL> _cUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL;
    
        public virtual ICollection<CUSTOM_S02004> CUSTOM_S02004
        {
            get
            {
                if (_cUSTOM_S02004 == null)
                {
                    var newCollection = new FixupCollection<CUSTOM_S02004>();
                    newCollection.CollectionChanged += FixupCUSTOM_S02004;
                    _cUSTOM_S02004 = newCollection;
                }
                return _cUSTOM_S02004;
            }
            set
            {
                if (!ReferenceEquals(_cUSTOM_S02004, value))
                {
                    var previousValue = _cUSTOM_S02004 as FixupCollection<CUSTOM_S02004>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCUSTOM_S02004;
                    }
                    _cUSTOM_S02004 = value;
                    var newValue = value as FixupCollection<CUSTOM_S02004>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCUSTOM_S02004;
                    }
                }
            }
        }
        private ICollection<CUSTOM_S02004> _cUSTOM_S02004;

        #endregion
        #region Association Fixup
    
        private void FixupCUSTOM_DOWNLOAD_TRANSACTION(CUSTOM_DOWNLOAD_TRANSACTION previousValue)
        {
            if (previousValue != null && previousValue.CUSTOM_DOWNLOAD_TRANSACTIONDATA.Contains(this))
            {
                previousValue.CUSTOM_DOWNLOAD_TRANSACTIONDATA.Remove(this);
            }
    
            if (CUSTOM_DOWNLOAD_TRANSACTION != null)
            {
                if (!CUSTOM_DOWNLOAD_TRANSACTION.CUSTOM_DOWNLOAD_TRANSACTIONDATA.Contains(this))
                {
                    CUSTOM_DOWNLOAD_TRANSACTION.CUSTOM_DOWNLOAD_TRANSACTIONDATA.Add(this);
                }
                if (TransactionID != CUSTOM_DOWNLOAD_TRANSACTION.ID)
                {
                    TransactionID = CUSTOM_DOWNLOAD_TRANSACTION.ID;
                }
            }
        }
    
        private void FixupCUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL item in e.NewItems)
                {
                    item.CUSTOM_DOWNLOAD_TRANSACTIONDATA = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CUSTOM_DOWNLOAD_TRANSACTIONDATADETAIL item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOM_DOWNLOAD_TRANSACTIONDATA, this))
                    {
                        item.CUSTOM_DOWNLOAD_TRANSACTIONDATA = null;
                    }
                }
            }
        }
    
        private void FixupCUSTOM_S02004(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CUSTOM_S02004 item in e.NewItems)
                {
                    item.CUSTOM_DOWNLOAD_TRANSACTIONDATA = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CUSTOM_S02004 item in e.OldItems)
                {
                    if (ReferenceEquals(item.CUSTOM_DOWNLOAD_TRANSACTIONDATA, this))
                    {
                        item.CUSTOM_DOWNLOAD_TRANSACTIONDATA = null;
                    }
                }
            }
        }

        #endregion
    }
}