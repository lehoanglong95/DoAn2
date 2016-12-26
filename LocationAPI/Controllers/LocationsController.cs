using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace LocationAPI.Controllers
{
    public class LocationsController : ApiController
    {
        /// <summary>
        /// Sử dụng phương thức GET để lấy toàn bộ thông tin về địa chỉ trong DB
        /// </summary>
        /// <returns>List toàn bộ các danh sách địa điểm (ví dụ dạng JSON, XML)</returns>
        //GET api/locations
        public List<Models.LocationInfo> Get()
        {
            var context = new Models.LocationInfoEntities(); //Lấy toàn bộ DL bên trong CSDL
            return context.LocationInfoes.ToList();
        }
        /// <summary>
        /// Insert dữ liệu vào CSDL, xử dụng method POST kèm theo các tham số tương ứng
        /// </summary>
        /// <param name="latitude">Vĩ độ</param>
        /// <param name="longitude">Kinh độ</param>
        /// <param name="subThoroughfare"></param>
        /// <param name="thoroughfare"></param>
        /// <param name="postalCode"></param>
        /// <param name="locality"></param>
        /// <param name="administrativeArea"></param>
        /// <param name="country"></param>
        /// <param name="userName">Tên người sử dụng đưa thông tin</param>
        /// <param name="timeStamp">Thời gian đưa thông tin</param>
        /// <returns>Trả lại "Success" nếu insert dữ liệu thành công</returns>
        //POST api/locations
        public String Post(double latitude, double longitude, String subThoroughfare, String thoroughfare, String postalCode, String locality, String administrativeArea, String country, String userName, String timeStamp)
        {
            if (ModelState.IsValid)
            {
                var context = new Models.LocationInfoEntities();
                Models.LocationInfo newLocationInfo =
                    new Models.LocationInfo()
                    {
                        Latitude = latitude,
                        Longitude = longitude,
                        SubThoroughfare = subThoroughfare,
                        Thoroughfare = thoroughfare,
                        PostalCode = postalCode,
                        Locality = locality,
                        AdministrativeArea = administrativeArea,
                        Country = country,
                        UserName = userName,
                        Timestamp = timeStamp
                    }; //tạo mới 1 đối tượng Entity về vị trí
                context.LocationInfoes.Add(newLocationInfo); //Thêm vào danh sách
                context.SaveChanges(); //Lưu các thay đổi vào DB
                return "Success";
            }
            return "Failed";        
        }
    }
}
