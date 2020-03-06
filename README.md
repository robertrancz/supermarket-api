# supermarket-api
A RESTful dotnet core API using a decoupled architecture

Domain layer
  - Models
  - Repository class interfaces
  - Service class interfaces
  
Using services, we can isolate the request and response handling from the real logic needed to complete tasks.
The services should not handle data.
The services should talk to repository classes which encapsulate the data access handling logic.

Resource classes
  - A resource class is a class that contains only basic information that will be exchanged between client applications and API endpoints, generally in form of JSON data, to represent some particular information.
  - All responses from API endpoints must return a resource.
  - It is a bad practice to return the real model representation as the response since it can contain information that the client application does not need or that it doesn’t have permission to have
  - For example, in this API we have a resource to represent only our categories, without the products
  - The mapping between models and resources are easily handled using the AutoMapper library
  - Notice the separate resources for read and creation operations!!!

Request-Response Pattern to Handle the Saving Logic (see CategoryResponse.cs)

The the Unit of Work Pattern (see UnitOfWork.cs)
  - Repositories shouldn’t save, update or delete data. Instead, they should delegate it to a different class to handle this logic.
  - There is another problem when saving data directly into a repository: you can't use transactions.
  - We should save our changes into the database only after everything finishes. To do this, we have to use a transaction.
  


  

