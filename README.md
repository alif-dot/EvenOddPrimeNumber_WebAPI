# EvenOddPrimeNumber_WebAPI

In an ASP.NET Core Web API, you can create endpoints to perform various operations, including determining whether a number is even, odd, or prime. Here's a description of how you can implement these functionalities in an ASP.NET Core Web API:

1. Even Number:
   An even number is divisible by 2 without leaving a remainder. To check if a number is even, you can create an API endpoint that accepts a number as input and returns a response indicating whether the number is even or not. Within the endpoint, you can use a simple condition to check if the number is divisible by 2.

2. Odd Number:
   An odd number is not divisible by 2 without leaving a remainder. Similarly to checking for even numbers, you can create an API endpoint that accepts a number and determines if it is odd or not. By using a condition to check if the number is not divisible by 2, you can identify odd numbers.

3. Prime Number:
   A prime number is a positive integer greater than 1 that has no divisors other than 1 and itself. Implementing a prime number check in an API endpoint involves creating a function that iterates through numbers up to the square root of the given number and checks if any of them divide the number evenly. If no divisors are found, the number is prime.

To implement these functionalities in an ASP.NET Core Web API, you can follow these steps:

1. Define API Endpoints: Create the necessary endpoints in your Web API, specifying the appropriate HTTP verbs, route templates, and parameter bindings. For example, you could have endpoints like `/api/numbers/even`, `/api/numbers/odd`, and `/api/numbers/prime`.

2. Implement the Logic: Within each endpoint's action method, implement the logic to determine if the given number is even, odd, or prime. Use conditional statements, loops, and mathematical operations as needed. Ensure that the appropriate response is returned based on the result.

3. Handle Input Validation: Validate the input provided to the API endpoints to ensure it is a valid number and within the expected range. Handle scenarios where the input is invalid or outside the desired range by returning appropriate error responses.

4. Return Responses: Return the results of the even, odd, and prime number checks as responses from the API endpoints. You can structure the response as JSON objects or utilize specific response types, such as `Ok`, `BadRequest`, or custom response classes.

5. Test the Endpoints: Thoroughly test the API endpoints using tools like Postman or by writing unit tests. Verify that the endpoints return the correct responses for different input values, including edge cases and boundary values.

By implementing these functionalities in an ASP.NET Core Web API, you can expose endpoints that allow clients to determine whether a given number is even, odd, or prime. This can be used in various scenarios, such as mathematical calculations, data analysis, or any application that requires number validation.
