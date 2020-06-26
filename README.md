# GitHub Searcher
Init View and Scripts added

Create an ASP.Net MVC (.Net Framework and C#) website:

         * A page containing a text box to enter a name in and a submit button to search GitHub for the name.
         
         * Have the back end call the GitHub users API (e.g. https://api.github.com/users/robconery) and get the users name, location and avatar url from the returned json. 
         * Use the repos_url value that’s returned to get a list of all the repos for the user. 
         
         * Do not use any third party tool for managing the api connection. 
         
         * Display the results below the search box.          
         * The results should show the username, location, avatar and the 5 repositories with the highest stargazer_count. 
         * For each repository, show the Name, FullName, Description and Stargazers. 
         * The Name should have a link to the repository.
         
         * Including unit tests: I have used https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2019
         
         The AAA (Arrange, Act, Assert) pattern is a common way of writing unit tests for a method under test.

            The Arrange section of a unit test method initializes objects and sets the value of the data that is passed to the method under test.

            The Act section invokes the method under test with the arranged parameters.

            The Assert section verifies that the action of the method under test behaves as expected.

         
         
