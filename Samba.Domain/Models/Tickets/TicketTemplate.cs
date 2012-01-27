﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Samba.Domain.Models.Accounts;
using Samba.Domain.Models.Menus;
using Samba.Domain.Models.Settings;
using Samba.Infrastructure.Data;

namespace Samba.Domain.Models.Tickets
{
    public class TicketTemplate : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Numerator TicketNumerator { get; set; }
        public virtual Numerator OrderNumerator { get; set; }

        private IList<TicketTagGroup> _ticketTagGroups;
        public virtual IList<TicketTagGroup> TicketTagGroups
        {
            get { return _ticketTagGroups; }
            set { _ticketTagGroups = value; }
        }

        private IList<ServiceTemplate> _serviceTemplates;
        public virtual IList<ServiceTemplate> ServiceTemplates
        {
            get { return _serviceTemplates; }
            set { _serviceTemplates = value; }
        }

        private IList<OrderTagGroup> _orderTagGroups;
        public virtual IList<OrderTagGroup> OrderTagGroups
        {
            get { return _orderTagGroups; }
            set { _orderTagGroups = value; }
        }

        public AccountTemplate SourceAccountTemplate { get; set; } // Sales
        public AccountTemplate TargetAccountTemplate { get; set; } // Customers
        public AccountTemplate PaymentAccountTemplate { get; set; } // Payments (Cash, Credit Card)
        
        public TicketTemplate()
        {
            _ticketTagGroups = new List<TicketTagGroup>();
            _serviceTemplates = new List<ServiceTemplate>();
            _orderTagGroups = new List<OrderTagGroup>();
        }
    }
}