namespace Week7CodeChallenge.Models
{
    using System;
    using System.Collections.Generic;

    public partial class ContactForms
    {

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string CompanyName { get; set; }
        public string ProjectDescription { get; set; }
        public string TextMessage { get; set; }
        public System.DateTime CreationDate { get; set; }
    }
}