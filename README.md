# Sample of [BindNever] attribute on controller action parameters
Sample for issue https://github.com/dotnet/AspNetCore.Docs/issues/25448

## Usage
1. Execute dotnet run in src folder
2. Access swagger in http://localhost:5000
3. Test /Sample/BindNever and /Sample/WithoutBindNever
4. Notice that:
    - /Sample/BindNever returns No Content.
    - /Sample/WithoutBindNever returns Ok with supplied model.
    - Both methods are identical otherwise.

Alternatively you can use curl

`curl -X 'POST' 'http://localhost:5000/Sample/BindNever' -H 'accept: */*' -H 'Content-Type: application/json' -d '{ "name": "test", "value": 1 }'`

`curl -X 'POST' 'http://localhost:5000/Sample/WithoutBindNever' -H 'accept: */*' -H 'Content-Type: application/json' -d '{ "name": "test", "value": 1 }'`

