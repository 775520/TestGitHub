using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class UIUtils
    {
        static string Constr = "Data source=.;Initial Catalog=ChangeFX;User ID=king;Password=Netsdl123";

        /// <summary>
        /// 查询全部数据
        /// </summary>
        /// <returns></returns>
        public static List<OrderExcel> SelectOrder()
        {
            try
            {
                List<OrderExcel> orderExcels = new List<OrderExcel>();

                SqlConnection con = ConnectSql();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                string sqlstr = "select * from OrderExcel";

                SqlDataReader reader = Reader(sqlstr, con);

                orderExcels = SerializeOrder(reader);

                con.Close();

                return orderExcels;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }

        public static OrderExcel SelectCondition(string Type,string Value)
        {
            OrderExcel order = new OrderExcel();
            string sqlstr = string.Empty;
            if (Type == "OrderHeadId")
            {
                sqlstr = string.Format("select * from OrderExcel where {0} = '{1}'", "LocalOrderHeadId", Value);
            }

            SqlConnection con = ConnectSql();

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataReader reader = Reader(sqlstr, con);

            order = SerializeOrder(reader)[0];

            con.Close();

            return order;

        }

        /// <summary>
        /// 创建链接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ConnectSql()
        {
            try
            {
                SqlConnection con = new SqlConnection(Constr);

                return con;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="Sqlstr"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        public static SqlDataReader Reader(string Sqlstr, SqlConnection con)
        {
            try
            {
                string SqlSeletc = Sqlstr;

                SqlCommand com = con.CreateCommand();

                com.CommandText = SqlSeletc;

                SqlDataReader DataReader = com.ExecuteReader();

                return DataReader;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static List<OrderExcel> SerializeOrder(SqlDataReader reader)
        {
            List<OrderExcel> orderExcels = new List<OrderExcel>();
            try
            {
                while (reader.Read())
                {
                    OrderExcel order = new OrderExcel();
                    order.Customer = reader["Customer"].ToString();
                    order.ItemNo= reader["ItemNo"].ToString();
                    order.LocalOrderHeadId= reader["LocalOrderHeadId"].ToString();
                    order.Ocean07A= reader["Ocean07A"].ToString();
                    order.Ocean07B= reader["Ocean07B"].ToString();
                    order.Ocean07C= reader["Ocean07C"].ToString();
                    order.Ocean07D= reader["Ocean07D"].ToString(); 
                    order.Ocean07E= reader["Ocean07E"].ToString(); 
                    order.OrderData= reader["OrderData"].ToString();
                    order.OrderNo= reader["OrderNo"].ToString(); 
                    order.OrderOriNo= reader["OrderOriNo"].ToString();
                    order.SendNum= reader["SendNum"].ToString();
                    order.SurplusNum= reader["SurplusNum"].ToString();
                    order.TotalNum= reader["TotalNum"].ToString();
                    orderExcels.Add(order);
                }
                return orderExcels;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <returns></returns>
        public static string InsertOrder(OrderExcel order)
        {
            try
            {
                string Message = string.Empty;

                SqlConnection con = ConnectSql();

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                string sqlstr = string.Format("INSERT INTO OrderExcel (LocalOrderHeadId, OrderData, OrderNo, OrderOriNo, Customer, ItemNo, TotalNum, SendNum, SurplusNum, Ocean07A, Ocean07B, Ocean07C, Ocean07D, Ocean07E) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", 
                    order.LocalOrderHeadId, order.OrderData, order.OrderNo, order.OrderOriNo, order.Customer, order.ItemNo,
                    order.TotalNum, order.SendNum, order.SurplusNum, order.Ocean07A, order.Ocean07B, order.Ocean07C, order.Ocean07D, order.Ocean07E);

                SqlCommand command = new SqlCommand(sqlstr, con);
                command.ExecuteNonQuery();

                 

                string Sql = string.Format("Insert into OrderInfoExcel (Jan,Remark1,Feb,Remark2,Mar,Remark3,Apr,Remark4,May,Remark5,Jun,Remark6,Jul," +
                    "Remark7,Aug,Remark8,Sep,Remark9,Oct,Remark10,Nov,Remark11,Dec,Remark12,LocalHeadId) values" +
                    " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}'," +
                    "'{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}')",
                    order.reamrk.Jan, order.reamrk.Remark1, order.reamrk.Feb, order.reamrk.Remark2, 
                    order.reamrk.Mar, order.reamrk.Remark3, order.reamrk.Apr, order.reamrk.Remark4,
                    order.reamrk.May, order.reamrk.Remark5, order.reamrk.Jun, order.reamrk.Remark6,
                    order.reamrk.Jul, order.reamrk.Remark7, order.reamrk.Aug, order.reamrk.Remark8, 
                    order.reamrk.Sep, order.reamrk.Remark9, order.reamrk.Oct, order.reamrk.Remark10, order.reamrk.Nov,
                    order.reamrk.Remark11, order.reamrk.Dec, order.reamrk.Remark12, order.reamrk.LocalheadId);

                SqlCommand com = new SqlCommand(Sql, con);
                com.ExecuteNonQuery();
                con.Close();
                return Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }       
        }
    }
}
