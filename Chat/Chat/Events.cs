using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chat
{
    // this file contains a number of EventArgs which enable various child forms
    // to call their parent forms.

    /// <summary>
    /// This class defines the EventArgs required for the Select an Image window
    /// to pass information back to its caller.
    /// </summary>
    public class NotifyImageSelectionToAddNewBuddyEventArgs : System.EventArgs
    {

        /// <summary>
        /// A run-time object constant that contains the Selected Image Index  
        /// in the Select a Image form
        /// </summary>
        public readonly int SelectedImageIndex;

        /// <summary>
        /// Event constructor.
        /// </summary>
        /// <param name="imageIndex">Index of the selected image</param>
        public NotifyImageSelectionToAddNewBuddyEventArgs(int imageIndex)
        {
            this.SelectedImageIndex = imageIndex;
        }
    }

    public class NotifyAddNewBuddyToTopParentEventArgs : System.EventArgs
    {

        /// <summary>
        /// Run-time object constants that contain the information required
        /// by the Buddy object.
        /// </summary>
        public readonly string HostName;
        public readonly string EmailAddress;
        public readonly string NickName;
        public readonly int Rating;
        public readonly int SelectedImageIndex;

        /// <summary>
        /// Event constructor.
        /// </summary>
        /// <param name="hostName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="nickName"></param>
        /// <param name="rating"></param>
        /// <param name="selectedImageIndex"></param>
        public NotifyAddNewBuddyToTopParentEventArgs(string hostName, string emailAddress, string nickName, int rating, int selectedImageIndex)
        {
            this.HostName = hostName;
            this.EmailAddress = emailAddress;
            this.NickName = nickName;
            this.Rating = rating;
            this.SelectedImageIndex = selectedImageIndex;
        }
    }

    /* public class NotifyOptionsToTopParentEventArgs : System.EventArgs
    {
        /// <summary>
        /// Run-time objects representing the properties on the Options form.
        /// </summary>

        // colors
        public readonly OptionsObject modifiedOptions;

        public NotifyOptionsToTopParentEventArgs(OptionsObject options)
        {
            this.modifiedOptions = options;
        }
    } */
}