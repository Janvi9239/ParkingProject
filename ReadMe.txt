Added Controllers for following:
- To get the no of parking spots at a location
- To add car to a location
- To remove car from a location
- When user tries to add a car it gets the license no and checks availability based on car type and adds to parking spot.
- There are lots of scope for improvement and several extensions that can be implemented. For example we could expand on the car type (see if they need electric or not) and also keep track of duration of parked hours. Track payment types and so on.
- In terms of architecture, we could use Entity framework use Db Context and create Repository classes for all the db updates.

Testing Locally :
- Currently have model classes and initialized some test data to test the API calls.