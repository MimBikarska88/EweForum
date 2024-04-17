# EweForum

This is my course project for C# Web Module 2024. I used the MVC design pattern, and in order to be able to make the UI a little more user-friendly used also some JQuery and Bootstrap. The configuration for the admin is put in user secrets file with the following contents:
{
  "Admin": {
    "email": "admin@eweforum.com",
    "password": "test_p@$$w0rd",
    "username": "Admin"
  }
  
}
Since the Admin user is configured, not created by the end user these credentials are used for its creation. I did not manage to finish the whole project on time and there are functionalities that are not implemented and no tests.

<sectio>
    <div class="d-flex flex-column justify-content-center">
        <div class="card m-2 text-center " style="text-align:justify">
            <div class="card-body  ">
                EweForum is a course project for Softuni C# WEB module. The goal was to create a simulated CMS like app where there are 2 categories of users
                - one and only Admin in charge of the whole forum that is created by a configuration in program.cs the first time the app runs, and forum users - each one
                with role user that needs to create account and log in in order to participate in the forum. At the moment there are 35 seeded users in the app and their passwords can be found in
                the users.json dataset which I used to seed the data. The reason I did it was because it seemed like a lot of object to put directly in an array inside .HasData() methods.
                Not all of the functionallity that I intended on doing is finished and I wish I did the project faster so that all of the requirements were met, but unfortunately I had to leave out some of
                them in order to finish on time.
            </div>
        </div>
        <h6>Here is the whole list of things the application implements. The ones that I did not have time for are marked in grey</h6>
        <ul class="mt-3 list-group list-group-flush">
            <li class="list-group-item">Implement authentication and authorization - ForumUser and Admin</li>
            <li class="list-group-item">User account registration</li>
            <li class="list-group-item">User account login</li>
            <li class="list-group-item">User account change password</li>
            <li class="list-group-item">User account edit</li>
            <li class="list-group-item">User select page size, sort and search topics</li>
            <li class="list-group-item">Join / Leave topics</li>
            <li class="list-group-item">User create posts</li>
            <li class="list-group-item">User browse through posts</li>
            <li class="list-group-item">Use of ViewBag, ViewData and TempData</li>
            <li class="list-group-item">User select the type of posts they want to create</li>
            <li class="list-group-item">Partial view for the 3 main types of posts (Event, Text and Media). Initially
                this was implemented by the approach of <a href="https://learn.microsoft.com/en-us/ef/core/modeling/inheritance#table-per-hierarchy-and-discriminator-configuration">Table-per-hierarchy and discriminator configuration</a>
                but then I thought it would slow me down and created a new migration where I used Enum for type and added it as a collumn.
            </li>
            <li class="list-group-item">
                <p>Closure table for replies</p>
                <p>
                    User is able to add a comment to post, and then another user could reply to this user's comment so it was very much looking
                    like a scenario that can cause endless recursion. So the only suitable answer that I received as a suggestion by a friend
                    who pointed me to this <a href="https://fueled.com/the-cache/posts/backend/closure-table/">Closure Table | The Cache</a>.
                </p>
            </li>
            <li class="list-group-item">Redirect to error page in case of 500, 404 and 401 status codes configured in Program.cs</li>
            <li class="list-group-item">Model state validations wherever possible</li>
            <li class="list-group-item disabled">Deployment</li>
            <li class="list-group-item disabled">Using external storage such as Redis or Dropbox </li>
            <li class="list-group-item disabled">65% Test Coverage - NONE </li>
            <li class="list-group-item disabled">HTML escape characters testing - none</li>
            <li class="list-group-item disabled">CRSF Token and further security</li>
            
        </ul>
    </div>
    

</section>
