﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("paymentType")]
    public class PaymentTypeEntity : Entity
    {
        public string name { get; set; }

        public virtual  ICollection<UserPaymentMenthodEntity> PaymentMenthod { get; set;}
    }
}