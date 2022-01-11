using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AdminController:BaseApiController
    {
        [Authorize(Policy="RequireAdminRole")]
        [HttpGet("users-with-roles")]
        public ActionResult GetUserWithRoles()
        {
            return Ok("Only admin can see this");
        }

        [Authorize(Policy="ModeratePhotoRole")]
        [HttpGet("photos-to-moderate")]
        public ActionResult GetPhotosForModeration()
        {
            return Ok("Admins or moderators can see this");
        }
    }
}