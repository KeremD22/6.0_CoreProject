using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void Delete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetList()
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetUserMessagesWithUser()
        {
            throw new NotImplementedException();
        }

        public void Insert(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public List<UserMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetUserMessageWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void Update(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
