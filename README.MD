<p align="center">
    <img src="cs.svg" alt="App Logo" width="128px" height="128px" />
</p>
<h1 align="center">E-Commerce App</h1>

<!-- TABLE OF CONTENTS -->
<h2 id="table-of-contents">:book: Table of Contents</h2>
<details open="open">
    <summary>Table of Contents</summary>
    <ol>
        <li><a href="#about-the-project"> ➤ About The Project</a></li>
        <li><a href="#overview"> ➤ Overview</a></li>
        <li><a href="#howtoinstall"> ➤ How to install</a></li>
        <li><a href="#project-files-description"> ➤ Project Files Description</a></li>
        <li><a href="#Credits"> ➤ Credits</a></li>
    </ol>
</details>

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

<!-- ABOUT THE PROJECT -->
<h2 id="about-the-project">:pencil: About The Project</h2>

<p align="justify">
    There are 2 websites in one website by merged built using the C#->.NET Core framewok with Entity framewok. One is the comparison site where notebook computers are scrapped from 4 different sites (trendyol, Hepsiburada, n11), and the other is the e-commerce site where all of these laptops are sold.
</p>

<ul>
    <li>
        In order to use the roles, 3 panels (admin, user) is designed in the interfaces.
    </li>
    <li>
        All required information is stored in a relational database (Sqlite).
    </li>
    <li>The database is designed with migrations.</li>
    <li>All performed operations can be viewed via in website.</li>
    <li>
        You can register, login, log out as both user and admin and use admin panel to change the products of the second web site.
    </li>
</ul>

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

<!-- OVERVIEW -->
<h2 id="overview">:cloud: Overview</h2>

<p align="justify">
    The project idea based on <a href="https://www.akakce.com">Akakce</a> and <a href="https://www.trendyol.com">Trendyol</a>. You can filter the products by their features like Ram, Graphic card, Model, Brand etc.
</p>

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)
<h2 id="howtoinstall">⛓️ How to install</h2>

<p align="justify">
    There are one easy way to deal with it:
<ol>
    <li>Build the project with ide or cmd</li>
    <ul>
        <li> Open the location where all the documents are located in visual studio code, visual studio, cmd or terminal.</li>
        <li> dotnet run --project scrapapp.webui </li>
        <li> Run this line of code in command line of ide or Cmd or terminal.</li>
        <li> You can see the website on localhost in your browser</li>
    </ul>
</ol>
</p>

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)
<!-- PROJECT FILES DESCRIPTION -->
<h2 id="project-files-description">📝 Project Files Description</h2>

<ul>
    <li><b>scrapapp.webui:</b>This layer includes functionalities related to the web user interface (UI). It typically handles tasks such as creating web pages, managing user login and logout, and processing user interactions. This layer receives requests from web browsers, processes them, and sends the results back to the user. User interface code is used to create web pages using technologies like HTML, CSS, and JavaScript.</li>
    <li><b>scrapapp.entity:</b>This layer includes entity classes that represent database tables and data models. The data model defines how the data is structured and how it relates to each other. This layer uses Object-Relational Mapping (ORM) tools to interact with the database and perform database operations.</li>
    <li><b>scrapapp.data:</b>This layer contains data access code used to perform database operations. It includes tasks such as establishing a connection to the database, adding, updating, and deleting data. Database communication is typically done using ORM tools (such as Entity Framework or Dapper).In this case Entity Framework.</li>
    <li><b>scrapapp.business:</b>This layer encompasses the business logic and rules of the application. It houses the code responsible for executing the core functions of the application. It handles user requests, coordinates database operations, and manages business processes. This layer ensures that the application functions according to the business requirements and rules.</li>
    <li><b>scrapapp.webapi:</b>This layer is that provides an interface for communicating with the outside world. This layer makes ScrapApp accessible to the external world, allowing other applications or services to interact with ScrapApp. For instance, a ScrapApp.WebAPI can enable other applications to use ScrapApp for data scraping from a specific website.</li>
</ul>
<p>The mentioned layers are typically used in a layered architecture model. This model enables better scalability, maintainability, and testability of the application. Each layer has distinct responsibilities, which helps in organizing and managing the code effectively.</p>

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

<!-- CREDITS -->
<h2 id="Credits">:scroll: Credits</h2>

[![GitHubBadge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/deniz-ozcan)[![LinkedInBadge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/98-deniz-ozcan/)
