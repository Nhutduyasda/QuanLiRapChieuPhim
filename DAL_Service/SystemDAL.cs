using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Service
{
    abstract public class SystemDAL<T, K>
    {
        abstract public void Insert(T entity);
        abstract public void Update(T entity);
        abstract public void Delete(K id);
        abstract public T selectById(K id);
        abstract public List<T> selectAll();
        abstract public List<T> selectBySql(string sql, List<Object> args, CommandType cmdType = CommandType.Text);
    }
}
