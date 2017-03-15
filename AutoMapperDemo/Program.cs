using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             automapper的作用:讲一个对象转换成另一个对象
             作用领域：1.将web中采集用户输入的ui数据表单转为dto，将dto转为领域模型后持久化到数据库中
                       2.将数据库中查询到的领域模型转换为dto然后映射到ui中
             automapper用法：1.根据属性名去转换，源和dto属性个数不同大小写不同但是名称相同便可以映射
                             2.自定义规则去映射，源和dto属性名称不同等通过规则去映射
              */

            //用法一：
            //初始目标类型新对象
            Mapper.Initialize(x => x.CreateMap<User, Userdto1>());
            Userdto1 user1 = Mapper.Map<Userdto1>(new User
            {
                Userage = 12,
                Username = "小华",
                Usersex = true,
                Useraccount = "1578946320",
                Userpassword = "123",
                Useremail = "myoueva.@foxmail",
                Userimg = "/path/1.jpg"
            });
            Console.WriteLine("姓名{0}性别{1}账号{2}密码{3}头像{4}", user1.Username, user1.Usersex == true ? "男" : "女", user1.Useraccount, user1.Userpassword, user1.Userimg);
            //用法二：
            //dest为目标领域模型。opt为源模型
            Mapper.Initialize(x => x.CreateMap<User, Userdto2>()
            .ForMember(dest => dest.Usernamedto, opt => opt.MapFrom(c => c.Username))
            .ForMember(dest => dest.Usersexdto, opt => opt.MapFrom(c => c.Usersex))
            .ForMember(dest => dest.Useraccountdto, opt => opt.MapFrom(c => c.Useraccount))
            .ForMember(dest => dest.Userpassworddto, opt => opt.MapFrom(c => c.Userpassword))
            .ForMember(dest => dest.Userimgdto, opt => opt.MapFrom(c => c.Userimg))
            );
            Userdto2 user2=Mapper.Map<Userdto2>(new User {
                Userage = 12,
                Username = "小红",
                Usersex = false,
                Useraccount = "1578946320",
                Userpassword = "123",
                Useremail = "myoueva.@foxmail",
                Userimg = "/path/2.jpg"
            });
            Console.WriteLine("姓名{0}性别{1}账号{2}密码{3}头像{4}", user2.Usernamedto, user2.Usersexdto == true ? "男" : "女", user2.Useraccountdto, user2.Userpassworddto, user2.Userimgdto);
            Console.ReadKey();

        }
    }
    public class User
    {
        public int Userage { get; set; }
        public string Username { get; set; }
        public bool Usersex { get; set; }
        public string Useraccount { get; set; }
        public string Userpassword { get; set; }
        public string Useremail { get; set; }
        public string Userimg { get; set; }
    }
    public class Userdto1
    {
        public string Username { get; set; }
        public bool Usersex { get; set; }
        public string Useraccount { get; set; }
        public string Userpassword { get; set; }
        public string Userimg { get; set; }
    }
    public class Userdto2
    {
        public string Usernamedto { get; set; }
        public bool Usersexdto { get; set; }
        public string Useraccountdto { get; set; }
        public string Userpassworddto { get; set; }
        public string Userimgdto { get; set; }
    }
}
