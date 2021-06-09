using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//first import = using System.Linq;
//LINQ is language intergated query used to fetch data from different data source like sql data base
//LINQ is used to write query
//2 types of LINQ syntax- quert syntax and method syntax
//it is used to work with data access from sources such as objects, datasets, SQL server
//to retrive my data through query , we use LINQ

/*            (objects)         (execute query)
c# application--------LINQ ------------------> Data source
                                (get results)       
*/



//operators  -From, select, where, orderby
//the data source in LINQ is a collection of objects,database,xml files
// *  means all

//NOTE=in Linq query we always use select at end                    //mandatory
//sorting in LINQ
//from i in age where i>20  orderby i select i  (ASCENDING)
// i ko orderby kro means sort kro



//LINQ supports ordering , sorting , grouping, filtering

namespace LINQ
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            //--------------------------------------------------------------
            //1) LINQ TO OBJECTS (using linq with arrays /collections)
            //make an array and store multiple values
            int[] age = { 10, 15, 30, 49, 50, 89, 40 };
            var a = from i in age where i > 20 select i;         //THIS IS LINQ query
        //sent aga ka  data in temporary variable i
        //select is for retrive data
        //select i = return /display data we give it at end in LINQ
        //after retriving data a will become array 

            foreach(var it in a)
            {
                Console.WriteLine(it);
            }
            Console.ReadLine();

            /*output = 30
49
50
89
40 */
            //-------------------------------------------------

            //sorting
            int[] ages = { 10, 15, 30, 49, 50, 89, 40 };
            var b = from j in ages where j > 20 orderby j descending select j;         //THIS IS LINQ query
                                                                            //orderby i = sort i
            foreach (var tt in b)
            {
                Console.WriteLine(tt);
            }
            Console.ReadLine();
            /*output = 89
    50
    49
    40
    30 */

            //-------------------------------------------------
            //using string as array
            string[] name = { "ros", "pay", "shi", "sak" };
            //appling LINQ in string
            var c = from x in name where x.Contains("s") select x;          //LINQ query
            //this means store in temporary variable x where name has character s (any character)

            //access then using foreach
            foreach (var op in c)
            {
                Console.WriteLine(op);
            }
            Console.ReadLine();
            /*output = ros
                             shi
                             sak
                         */
            //-------------------------------------------------
            //startswith

            string[] names = { "ros", "pay", "shi", "sak" };
            //appling LINQ in string
            var d = from y in name where y.StartsWith("s") select y;          //LINQ query

            //access then using foreach
            foreach (var eo in d)
            {
                Console.WriteLine(eo);
            }
            Console.ReadLine();

            /*output = shi
                            sak */
            //---------------------------------------------------------------------------
            //---------------------------------------------------------------------------
            //2) LINQ TO SQL
            //is used for working with RDBMS
            //it allows us to perform CRUD operations like create, read,update, delete
            //we write SQL queries in double quotes it means write them in string
            //strings are sent to database and are executed by sql server database engine
            //sql queries are checked during runtime
            //then database engine is going to verify that the query is right or wrong

            //LINQ to SQL will convert-
            //RELATIONAL TYPES  --------------------->object oriented types //this process of converting relational database to object oriented types is called ORM(object relational mapper)
            // table -------------------------------> class 
            //table column ------------------------> class property
            //row -----------------------------------> object/instance
            //stored procedure ----------------------> method


            //steps to implement LINQ to SQL in windows form application
            //1)tool used in ORM is called OR designer
            //2)add namespace system.Data.LINQ
            //3)in app.config file write connection string

            //to make table
            //for this go to solution explorer ->click project->click add->click new item->click data->click service based database->rename data base 
            //now go to server explorer on left hand side ->click Database connection ->click tables->add new table->add details in table->to save click update->click update database->again go to server explorer->click student table->click refresh->click show table data

            //for OR designer
            //      for this go to solution explorer->click project->click add->click new item->click data->click linq to sql->rename the same name as of first database(Student)->click create->drag and drop student table from server explorer to Student.dbml
            //now go and see App.config->u will find that  connectionString has got generated
            //also in References in solution explorer System.Data.Linq has been added automtically
            //so three steps mentioned above for steps to implement LINQ to SQL in windows form application has been completed
            //now go to form1.cs and double click the square bracket, it will generate the events (codes)
            //in form1.cs write line 22 to 29


            Form1 ff = new Form1();
            Application.Run(ff);
        }

    }
}
