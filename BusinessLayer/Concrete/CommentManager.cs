using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager: ICommentService
    {
        ICommentData _commentdal;
        Repository<Comment> repocomment = new Repository<Comment>();

        public CommentManager(ICommentData commentdal)
        {
            _commentdal = commentdal;
        }

        public List<Comment> CommentList()
        {
            return repocomment.List();
        }
        public List<Comment> CommentByIDBlog(int id)
        {
            return _commentdal.List(x => x.BlogID == id);
        }
        public List<Comment> CommebtByStatusTrue()
        {
            return _commentdal.List(x => x.commentstatus == true);
        }
        public List<Comment> CommentStatusFalse()
        {
            return repocomment.List(x=>x.commentstatus==false);
        }
        public void CommentStatusChangeToFalse(int id)
        {
            Comment comment = _commentdal.Fİnd(x => x.CommentID == id);
            comment.commentstatus = false;
            _commentdal.Update(comment);
        }
        public void CommentStatusChangeToTrue(int id)
        {
            Comment comment = _commentdal.Fİnd(x => x.CommentID == id);
            comment.commentstatus = true;
            _commentdal.Update(comment);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void CommentDelete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
            _commentdal.Insert(t);
        }

        public void TtDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
