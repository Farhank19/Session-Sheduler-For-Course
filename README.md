# Session-Sheduler-For-Course

# Course
Add/Update Course Url (post)- https://localhost:44392/api/course/Save
object -- 
{
	"id":3,
"courseName": "English",
"description": "Eng description",
"coachName": "Roy"
}

Get course by name (get) - https://localhost:44392/api/course/get/math
Get course (get) - https://localhost:44392/api/course/get


# Session
Add/Update Session Url (post)- https://localhost:44392/api/session/Save
object -- 
{
"id": 3,
"title": "Title",
"agenda": "agenda",
"link": "link",
"startTime": "2022-02-20T10:00:00",
"endTime": "2022-02-20T10:30:00",
"courseId": 1,
"courseName": "math"
}

Get session by course id (get) -https://localhost:44392/api/Session/GetByCourseId/1
Get session (get) - https://localhost:44392/api/Session/get
delete session (post) - https://localhost:44392/api/Session/delete/2
