using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class ArticleDal
    {
        private string conn = ConfigurationManager.AppSettings["ConnMySQL"];

        public DataTable SelectArticleAll(string minPage, string maxPage)
        {
            string sql = String.Format("select r.id as rid, r.article_title as title, r.article_Content as content, r.article_Date as date, r.article_access as access, t.tag_Name as tag, t.id as tid, u.admin_Name as uname, u.admin_Head as uhead, u.id as uid from bzm_article r, bzm_admin u, bzm_tag t where r.article_AdminId=u.id and r.article_TagId=t.id order by r.article_Date desc limit {0}, {1}", minPage, maxPage);

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


        public DataTable SelectArticleByTag(string tid, string minPage, string maxPage)
        {
            string sql = String.Format("select r.id as rid, r.article_title as title, r.article_Content as content, r.article_Date as date, r.article_access as access, t.tag_Name as tag, t.id as tid, u.admin_Name as uname, u.admin_Head as uhead, u.id as uid from bzm_article r, bzm_admin u, bzm_tag t where r.article_AdminId=u.id and r.article_TagId=t.id and t.id={0} order by r.article_Date desc limit {1}, {2}", tid, minPage, maxPage);

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


        public DataTable SelectArticleByRid(string rid)
        {
            string sql = String.Format("select r.id as rid, r.article_title as title, r.article_Content as content, r.article_Date as date, r.article_access as access, t.tag_Name as tag, t.id as tid, u.admin_Name as uname, u.admin_Head as uhead, u.id as uid from bzm_article r, bzm_admin u, bzm_tag t where r.article_AdminId=u.id and r.article_TagId=t.id and r.id={0}", rid);

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


        public string InsertComment(string rid, string name, string content)
        {
            string sql = String.Format("insert into bzm_comment(comm_user, comm_content, comm_date, comm_articleId, remark) value('{0}', '{1}', sysdate(), {2}, null)", name, content, rid);

            string result = Util.MySqlUtil.ExecuteSql(conn, sql);

            return result;
        }


        public DataTable SelectCommentByRid(string rid)
        {
            string sql = String.Format("select id, comm_user as uname, comm_content as content, comm_date as date, comm_articleId as rid from bzm_comment where comm_articleId={0}", rid);

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


        public string InsertAccess(string url, string ip, string dns, string browser)
        {
            string sql = String.Format("insert into bzm_access(acc_url, acc_ip, acc_dns, acc_browser, acc_date) values('{0}', '{1}', '{2}', '{3}', sysdate())", url, ip, dns, browser);

            string result = Util.MySqlUtil.ExecuteSql(conn, sql);

            return result;
        }


        public DataTable SelectUserByNameAndPswd(string name, string pswd)
        {
            string sql = String.Format("select * from bzm_admin where admin_Name='{0}' and admin_Pswd='{1}';", name, pswd);

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


        public DataTable SelectAccessList(string minPage, string maxPage)
        {
            string sql = String.Format("select id, acc_url as url, acc_ip as ip, acc_dns as dns, acc_browser as browser, acc_date as date from bzm_access order by acc_date desc limit {0}, {1}", minPage, maxPage);

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


        public string InsertArticle(string title, string content, string tag)
        { 
            string sql = String.Format("insert into bzm_article(article_title ,article_content, article_date, article_tagid, article_access, article_adminId, remark) " +
                                       "values('{0}', '{1}', sysdate(), {2}, 1, 1, '')", title, content, tag);

            string result = Util.MySqlUtil.ExecuteSql(conn, sql);

            return result;
        
        }


        public DataTable SelectTags()
        {
            string sql = String.Format("select * from bzm_tag order by id asc");

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


        public DataTable SelectArticleByTag(string tid)
        {
            string sql = String.Format("select id, article_title as title, article_date as date, article_adminId as admin, article_access as access from bzm_article where article_tagId={0} order by article_date desc", tid);

            DataTable dt = Util.MySqlUtil.ExecuteDataset(conn, CommandType.Text, sql).Tables[0];

            return dt;
        }


    }
}
