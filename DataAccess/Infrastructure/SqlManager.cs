using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess.Infrastructure
{
    public class SqlManager
    {
        private StringDictionary Queries;
        private static SqlManager sqlManager = null;
        string FName;
        protected SqlManager()
        {

        }

        public static SqlManager Create(string FileName)
        {
            if (sqlManager == null)
            {
                sqlManager = new SqlManager();
                sqlManager.LoadSqlFile(FileName);
            }
            return sqlManager;
        }

        public void LoadSqlFile(string FileName)
        {
            FName = FileName;
        }

        public string GetQuery(string ID)
        {
            try
            {
                XmlTextReader qr = new XmlTextReader(FName);
                //DataTable dt = qr.MoveToContent
                string Query = string.Empty;

                string id = "";
                //bool btrue = true;
                //if (btrue)
                //{
                while (qr.Read())
                {
                    switch (qr.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (qr.Name.Equals("SQL"))
                            {
                                while (qr.MoveToNextAttribute())
                                {
                                    if (qr.Name.Equals("ID"))
                                    {
                                        id = qr.Value;
                                        if (id.Trim().ToLower() == ID.Trim().ToLower())
                                        {
                                            Query = qr.ReadString();
                                            //btrue = false;
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        case XmlNodeType.Comment:
                            Queries.Add(id, qr.Value);
                            id = "";
                            break;
                    }
                }
                //}

                qr.Close();
                return Query;
            }
            catch (Exception ex)
            {
                //ILog log = new ObserverLogToDatabase();
                //log.ErrorLog(null, null, null, null, ex);

                ////ErrorSignal.FromCurrentContext().Raise(ex);

                return null;
            }
        }
    }
}
