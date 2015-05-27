using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePublisher
{
    /// <summary>
    /// Your TODO: please follow insstruction 
    /// </summary>
    public class MessagesViewModel: IMessagesViewModel
    {
        private readonly IDispatcher _dispatcher;
        private IEnumerable<UserQueue> _observedUsers;
        private DateTime _toDate;
        private DateTime _fromDate;
        private string _textFilter;
        private IEnumerable<Message> _filteredMessages;
        private string _newMessageText;
        public MessagesViewModel(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            _observedUsers = Globals.GetRandomDataForAllUsers(30,10);
            _toDate = new DateTime(2015, 5, 27);
            _fromDate = new DateTime(2014, 5, 27);
           // FilterCommand();
        }


        public string UserName
        {

            get { return; }//_observedUser.First<>
        }

        public UserQueue SelectedUser
        {
            get
            {
                return SelectedUser;
            }
            set
            {
                if (PropertyChanged != null)
                {
                    SelectedUser = value;
                }
            }
        }

        public IEnumerable<UserQueue> ObservedUsers
        {

            get { return _observedUsers; }
        }

        public string NewMessageText
        {
            get
            {
                return _newMessageText;
            }
            set
            {
                if (_newMessageText != null)
                {
                    _newMessageText = value;
                }
            }
        }

        public System.Windows.Input.ICommand PublishCommand
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime FromDate
        {
            get
            {
                return _fromDate;
            }
            set
            {
                if (_fromDate == value)
                {
                    return;
                }
                _fromDate = value;
            }
        }

        public DateTime ToDate
        {
            get
            {
                return _toDate;
            }
            set
            {
                 if (_toDate == value)
                {
                    return;
                }
                _toDate = value;
                
            }
        }

        public string TextFilter
        {
            get
            {
                return _textFilter;
            }
            set
            {
                 if (_textFilter == value)
                {
                    return;
                }
                _textFilter = value;
                FilterCommand(value);
            }
        }

        public void FilterCommand(string value)
        {
            if (value != null && SelectedUser != null)
            {
                DateMessageSearcher dmsearcher = new DateMessageSearcher(_fromDate, _toDate);
                TextMessageSearcher tmsearcher = new TextMessageSearcher(_textFilter);
               // FilteredMessages.Add
            }
        }

        public string Author { get; set; }
        public string Content{ get; set; }
        public DateTime PublishedOn { get; set; }

        public void SearchCommand()
        {
            Author = UserName;
            Content = NewMessageText;
            PublishedOn = ToDate;
            FilterCommand();
        }

        public System.Windows.Input.ICommand FilterCommand
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<Message> FilteredMessages
        {
            get { return _filteredMessages; }
        }

        public System.Windows.Input.ICommand SaveCommand
        {
            get { throw new NotImplementedException(); }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
