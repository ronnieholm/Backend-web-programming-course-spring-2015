# Lecture 10

- TODO:
    Add JSON som curriculum
    HTTP protocol
    Create jQuery method which calls methods on server
    Take one of the previous exercises and convert into Web API
    Model validation
    Fiddler showing interaction with Console

- 0910-1100
  - Static language class

  - Design patterns (2013 presentation)

  - HTTP protocol
    - Telnet
    - Fiddler
    - Verbs
      - GET
      - POST
      - PUT
      - DELETE

  - Web API
    - Create AspNetWebApiDemo project
      1. File -> New -> Project -> ASP.NET Web Application
      2. Empty template
      3. Web API core references 
    - Explain folder structure
    - Routing rules
    - Content negotiation with Accept header (what I want back from service)
      - Accept header (what I want back from service)     
        Change Accept header from 
          Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8
        To 
          Accept: application/xml
        To
          Accept: application/json
      - Content-Type header (What I sent to service)
        Add
          Content-Type: application/json