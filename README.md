![.NET Core](https://github.com/es-hackathon/bookmark-dashboard-api/workflows/.NET%20Core/badge.svg)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/f1ee217e5eba46a4b6e8002d4c729c5c)](https://www.codacy.com?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=es-hackathon/bookmark-dashboard-api&amp;utm_campaign=Badge_Grade)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/es-hackathon/bookmark-dashboard-api/blob/develop/LICENSE)


# Bookmark Dashboard Web API




<br />
<p align="center">
  <a href="#">
    <img src="docs/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Bookmark Dashboard Web API</h3>

  <p align="center">
    Web API solution template which is built on Clean Architecture using .Net Core for bookmark dashboard project!
    <br />
    <a href="https://amitpnk.github.io/Onion-architecture-ASP.NET-Core/"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/es-hackathon/bookmark-dashboard-api">Download</a>
    ·
    <a href="https://github.com/es-hackathon/bookmark-dashboard-api/issues/new?assignees=&labels=&template=bug_report.md&title=">Report Bug</a>
    ·
    <a href="https://github.com/es-hackathon/bookmark-dashboard-api/issues/new?assignees=&labels=&template=feature_request.md&title=">Request Feature</a>
  </p>
</p>


<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
* [Getting Started](#getting-started)
* [Features available in this project](#Features-available-in-this-project)
* [Project description](#project-description)
* [Design patterns Used](#roadmap)
* [Licence Used](#Licence-Used)


# About the Project

Web API solution template which is built on Clean Architecture using .Net Core for bookmark dashboard project!

# Layer Dependencies

![layer dependencies](./docs/layer-dependencies.png)

<details>
  <summary><b>Domain layer</b></summary>
  <p>
    Domain Layers (Core layer) is implemented in center and never depends on any other layer. Therefore, what we do is that we create interfaces to Persistence layer and these interfaces get implemented in the external layers. This is also known and DIP or Dependency Inversion Principle
  </p>
</details>
<details>
  <summary><b>Persistence layer</b></summary>
  <p>
    In Persistence layer where we implement reposistory design pattern. In our project, we have implement Entityframework which already implements a repository design pattern. DbContext will be UoW (Unit of Work) and each DbSet is the repository. This interacts with our database using dataproviders
  </p>
</details>
<details>
  <summary><b>Application layer</b></summary>
  <p>
    Application layer where we can implement business logic. For OLAP/OLTP process, we can implement CQRS design pattern. In our project, we have implemented CQRS design pattern on top of Mediator design pattern via MediatR libraries
  </p>
  <p>In case you want to implement email feature logic, we define an IMailService in the Service Layer.
  Using DIP, it is easily possible to switch the implementations. This helps build scalable applications.
  </p>
</details>
<details>
  <summary><b>Infrastructure Layer</b></summary>
  <p>
    In this layer, we add our third party libraries like JWT Tokens Authentication or Serilog for logging, etc.
  </p>
</details>
<details>
  <summary><b>Cross cutting concern</b></summary>
  <p>
    In this layer, we add caching and other logic which will be common to all layer
  </p>
</details>
<details>
  <summary><b>Presentation Layer</b></summary>
  <p>
    This can be WebApi or UI.
  </p>
</details>

## Layer examples

![layer examples](./docs/layer-examples.png)

