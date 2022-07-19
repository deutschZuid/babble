using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chat
{
    public partial class Buddy
    {
        private string hostname, nickname, emailaddress;
        private int imageindex, rating;

        // buddyindex is now an obsolete member
        private int buddyindex;

        /// <summary>
        /// Overloaded constructor that accepts all buddy parameters
        /// </summary>
        /// <param name="hostname"></param>
        /// <param name="name"></param>
        /// <param name="imageindex"></param>
        /// <param name="buddyindex"></param>
        /// <param name="email"></param>
        /// <param name="rating"></param>
        public Buddy(string hostname, string name, int imageindex, int buddyindex, string email, int rating)
        {
            this.hostname = hostname;
            this.nickname = name;
            this.imageindex = imageindex;
            this.buddyindex = buddyindex;
            this.emailaddress = email;
            this.rating = rating;

        }

        /// <summary>
        /// Default constructor with null and -1 values
        /// </summary>
        public Buddy()
        {
            this.hostname = null;
            this.nickname = null;
            this.emailaddress = null;
            this.buddyindex = -1;
            this.imageindex = -1;
            this.rating = -1;
        }

        public int Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public int ImageIndex
        {
            get
            {
                return imageindex;
            }

            set
            {
                imageindex = value;
            }
        }

        public string NickName
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public string HostName
        {
            get
            {
                return hostname;
            }

            set
            {
                hostname = value;
            }
        }

        public int BuddyNodeIndex
        {
            get
            {
                return buddyindex;
            }

            set
            {
                buddyindex = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return emailaddress;
            }

            set
            {
                emailaddress = value;
            }
        }
    }
}
