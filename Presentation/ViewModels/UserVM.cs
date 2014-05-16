using SandBox.DO.dbo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.ViewModels
{
    public class UserVM
    {
        public UserVM()
        {
        }



        public UserVM(UserDO data)
        {
            this.UserId = data.UserId;
            this.FirstName = data.FirstName;
            this.LastName = data.LastName;
            this.MiddleInitial = data.MiddleInitial;
            this.EmailAddress = data.EmailAddress;
            this.PhoneNumber = data.PhoneNumber;
            this.Address1 = data.Address1;
            this.Address2 = data.Address2;
            this.City = data.City;
            this.State = data.State;
            this.ZipCode = data.ZipCode;
        }

        /// <summary>
        /// returns the data object version of the view model
        /// </summary>
        /// <returns></returns>
        public UserDO GetDataObject()
        {
            return new UserDO()
            {
                UserId = this.UserId,
                FirstName = this.FirstName,
                LastName = this.LastName,
                MiddleInitial = this.MiddleInitial,
                EmailAddress = this.EmailAddress,
                PhoneNumber = this.PhoneNumber,
                Address1 = this.Address1,
                Address2 = this.Address2,
                City = this.City,
                State = this.State,
                ZipCode = this.ZipCode
            };
        }

        /// <summary>
        /// All of the continental united states in a format to display in a dropdown list
        /// </summary>
        public List<SelectListItem> States
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>();
                items.Add(new SelectListItem() { Value = "", Text = "Select a State" });
                items.Add(new SelectListItem() { Value = "AL", Text = "Alabama", Selected = this.State == "AL" });
                items.Add(new SelectListItem() { Value = "AK", Text = "Alaska", Selected = this.State == "AK" });
                items.Add(new SelectListItem() { Value = "AZ", Text = "Arizona", Selected = this.State == "AZ" });
                items.Add(new SelectListItem() { Value = "AR", Text = "Arkansas", Selected = this.State == "AR" });
                items.Add(new SelectListItem() { Value = "CA", Text = "California", Selected = this.State == "CA" });
                items.Add(new SelectListItem() { Value = "CO", Text = "Colorado", Selected = this.State == "CO" });
                items.Add(new SelectListItem() { Value = "CT", Text = "Connecticut", Selected = this.State == "CT" });
                items.Add(new SelectListItem() { Value = "DE", Text = "Delaware", Selected = this.State == "DE" });
                items.Add(new SelectListItem() { Value = "FL", Text = "Florida", Selected = this.State == "FL" });
                items.Add(new SelectListItem() { Value = "GA", Text = "Georgia", Selected = this.State == "GA" });
                items.Add(new SelectListItem() { Value = "HI", Text = "Hawaii", Selected = this.State == "HI" });
                items.Add(new SelectListItem() { Value = "ID", Text = "Idaho", Selected = this.State == "ID" });
                items.Add(new SelectListItem() { Value = "IL", Text = "Illinois", Selected = this.State == "IL" });
                items.Add(new SelectListItem() { Value = "IN", Text = "Indiana", Selected = this.State == "IN" });
                items.Add(new SelectListItem() { Value = "IA", Text = "Iowa", Selected = this.State == "IA" });
                items.Add(new SelectListItem() { Value = "KS", Text = "Kansas", Selected = this.State == "KS" });
                items.Add(new SelectListItem() { Value = "KY", Text = "Kentucky", Selected = this.State == "KY" });
                items.Add(new SelectListItem() { Value = "LA", Text = "Louisiana", Selected = this.State == "LA" });
                items.Add(new SelectListItem() { Value = "ME", Text = "Maine", Selected = this.State == "ME" });
                items.Add(new SelectListItem() { Value = "MD", Text = "Maryland", Selected = this.State == "MD" });
                items.Add(new SelectListItem() { Value = "MA", Text = "Massachusetts", Selected = this.State == "MA" });
                items.Add(new SelectListItem() { Value = "MI", Text = "Michigan", Selected = this.State == "MI" });
                items.Add(new SelectListItem() { Value = "MN", Text = "Minnesota", Selected = this.State == "MN" });
                items.Add(new SelectListItem() { Value = "MS", Text = "Mississippi", Selected = this.State == "MS" });
                items.Add(new SelectListItem() { Value = "MO", Text = "Missouri", Selected = this.State == "MO" });
                items.Add(new SelectListItem() { Value = "MT", Text = "Montana", Selected = this.State == "MT" });
                items.Add(new SelectListItem() { Value = "NE", Text = "Nebraska", Selected = this.State == "NE" });
                items.Add(new SelectListItem() { Value = "NV", Text = "Nevada", Selected = this.State == "NV" });
                items.Add(new SelectListItem() { Value = "NH", Text = "New Hampshire", Selected = this.State == "NH" });
                items.Add(new SelectListItem() { Value = "NJ", Text = "New Jersey", Selected = this.State == "NJ" });
                items.Add(new SelectListItem() { Value = "NM", Text = "New Mexico", Selected = this.State == "NM" });
                items.Add(new SelectListItem() { Value = "NY", Text = "New York", Selected = this.State == "NY" });
                items.Add(new SelectListItem() { Value = "NC", Text = "North Carolina", Selected = this.State == "NC" });
                items.Add(new SelectListItem() { Value = "ND", Text = "North Dakota", Selected = this.State == "ND" });
                items.Add(new SelectListItem() { Value = "OH", Text = "Ohio", Selected = this.State == "OH" });
                items.Add(new SelectListItem() { Value = "OK", Text = "Oklahoma", Selected = this.State == "OK" });
                items.Add(new SelectListItem() { Value = "OR", Text = "Oregon", Selected = this.State == "OR" });
                items.Add(new SelectListItem() { Value = "PA", Text = "Pennsylvania", Selected = this.State == "PA" });
                items.Add(new SelectListItem() { Value = "RI", Text = "Rhode Island", Selected = this.State == "RI" });
                items.Add(new SelectListItem() { Value = "SC", Text = "South Carolina", Selected = this.State == "SC" });
                items.Add(new SelectListItem() { Value = "SD", Text = "South Dakota", Selected = this.State == "SD" });
                items.Add(new SelectListItem() { Value = "TN", Text = "Tennessee", Selected = this.State == "TN" });
                items.Add(new SelectListItem() { Value = "TX", Text = "Texas", Selected = this.State == "TX" });
                items.Add(new SelectListItem() { Value = "UT", Text = "Utah", Selected = this.State == "UT" });
                items.Add(new SelectListItem() { Value = "VT", Text = "Vermont", Selected = this.State == "VT" });
                items.Add(new SelectListItem() { Value = "VA", Text = "Virginia", Selected = this.State == "VA" });
                items.Add(new SelectListItem() { Value = "WA", Text = "Washington", Selected = this.State == "WA" });
                items.Add(new SelectListItem() { Value = "WV", Text = "West Virginia", Selected = this.State == "WV" });
                items.Add(new SelectListItem() { Value = "WI", Text = "Wisconsin", Selected = this.State == "WI" });
                items.Add(new SelectListItem() { Value = "WY", Text = "Wyoming", Selected = this.State == "WY" });

                return items;
            }
        }


        public Int32 UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public String FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial")]
        [MaxLength(1)]
        public String MiddleInitial { get; set; }

        [Display(Name = "Email Address")]
        [MaxLength(150)]
        public String EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(20)]
        public String PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        [MaxLength(150)]
        public String Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        [MaxLength(150)]
        public String Address2 { get; set; }

        [Required]
        [Display(Name = "City")]
        [MaxLength(50)]
        public String City { get; set; }

        [Required]
        [Display(Name = "State")]
        [MaxLength(2)]
        public String State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [MaxLength(10)]
        public String ZipCode { get; set; }

    }
}