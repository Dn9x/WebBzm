using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Util;
using System.Data;

namespace BLL
{
    public class ArticleBll
    {
        public DataTable GetArticleDataTable(string minPage, string maxPage)
        {
            ArticleDal ad = new ArticleDal();

            return ad.SelectArticleAll(minPage, maxPage);
        }


        public string GetArticleJson(string tid, string minPage, string maxPage)
        {
            ArticleDal ad = new ArticleDal();

            DataTable dt = null;

            if (tid == "EM")
            {
                dt = ad.SelectArticleAll(minPage, maxPage);
            }
            else
            {
                dt = ad.SelectArticleByTag(tid, minPage, maxPage);
            }

            string result = JsonUtil.DataTableToJson(dt);

            return result;
        }


        public DataTable GetArticleByRid(string rid)
        {
            ArticleDal ad = new ArticleDal();

            DataTable dt = ad.SelectArticleByRid(rid);

            return dt;
        }


        public string AddComment(string rid, string name, string content)
        {
            ArticleDal ad = new ArticleDal();

            return ad.InsertComment(Util.InputUtil.ReplaceInput(rid), Util.InputUtil.ReplaceInput(name), Util.InputUtil.ReplaceInput(content));
        }


        public string GetCommentByRid(string rid)
        {
            ArticleDal ad = new ArticleDal();

            DataTable dt = ad.SelectCommentByRid(rid);

            string result = JsonUtil.DataTableToJson1(dt);

            return result;
        }


        public string SaveAccess(string url, string ip, string dns, string browser)
        {
            ArticleDal ad = new ArticleDal();

            return ad.InsertAccess(url, ip, dns, browser);
        }


        public DataTable GetUserByNameAndPswd(string name, string pswd)
        {
            ArticleDal ad = new ArticleDal();

            return ad.SelectUserByNameAndPswd(InputUtil.ReplaceInput(name), pswd);
        }


        public string GetAccessList(string minPage, string maxPage)
        {
            ArticleDal ad = new ArticleDal();

            DataTable dt = ad.SelectAccessList(minPage, maxPage);

            return JsonUtil.DataTableToJson(dt);
        }


        public string AddArticle(string title, string content, string tag)
        {
            ArticleDal ad = new ArticleDal();

            return ad.InsertArticle(title, content, tag);
        }


        public DataTable GetTags()
        {
            ArticleDal ad = new ArticleDal();

            return ad.SelectTags();
        }


        public DataTable GetArticleByTag(string tid)
        {
            ArticleDal ad = new ArticleDal();

            return ad.SelectArticleByTag(tid);
        }

    }
}
