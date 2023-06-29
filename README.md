# BDD and SpecFlow Overview and Examples <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Overview](#1-overview)
- [2. What is BDD](#2-what-is-bdd)
- [3. What is Cucumber](#3-what-is-cucumber)
- [4. What is Gherkin](#4-what-is-gherkin)
  - [4.1. Why learn Gherkin](#41-why-learn-gherkin)
  - [4.2. User stories](#42-user-stories)
    - [4.2.1. Need to know](#421-need-to-know)
  - [4.3. Example user story](#43-example-user-story)
    - [4.3.1. Questions and answers](#431-questions-and-answers)
  - [4.4. Keywords](#44-keywords)

# 1. Overview

- Specflow is a Cucumber implementation library for .NET to enable developers to convert Gherkin BDD scenarios into actual .NET code for automated testing.
- Specflow is very popular as it integrates with Visual Studio and is really easy to use.
- **Gherkin is used to write business scenarios in a human language, and Specflow will interpret these scenarios and convert them into executable .NET code.**

# 2. What is BDD

- **BDD is Behaviour Driven Development.**
- **Eencouraging teams to collaborate together**, across the business regardless of their role.
- It **helps to build a shared understanding of the problem** space and how it can be solved.
- BDD helps by breaking down user problems into small pieces, which can then be put through the development process as fast as possible.
- This enables the team to respond quickly to any feedback from users and do the least amount of work necessary to fulfil the business needs.
- And it also **produces up-to-date documentation** which is validated automatically along with the system behaviour.

# 3. What is Cucumber

- Cucumber is an open source software tool that supports Behaviour Driven Development.
- It offers ways to write scenarios and tests so that anyone can understand them, even without technical knowledge.
- Acceptance tests are written, which describe the behavior of the system being tested from a business perspective before the developers write any code.
- It's available in many languages and just a few are shown here, but there are many more implementations.

# 4. What is Gherkin

- Cucumber writes acceptance tests and scenarios in an English like language, using certain keywords with a particular syntax.
- This simple English like text is called the Gherkin language.
- Because Gherkin is in a certain syntax with known keywords, it can be parsed and understood by the Cucumber software in order to validate these scenarios and test the software against the acceptance criteria.

## 4.1. Why learn Gherkin

- Essential to learn if using BDD / Cucumber.
- Widely used by testing professionals.
- Widely used by business analysts.
- Look great on resume / CV.
- Gherkin is a universal language.

## 4.2. User stories

- If we have a product or software which has a user interface, then we should be able to produce what is known as user stories.
- So user stories are a description in an informal **way of a user's journey through a feature or functionality**.
- It's written from the **user's perspective** and not from the system's point of view.
- A user story should have an **acceptance criteria**, what is the expected result if the user **achieves their goal**.
- You should also have an action, it should also have an action which the user should perform to get the expected result.
- The user story also needs to **have some criteria**, which are certain conditions that should be met to perform the action.
- User stories are used if a development process adopts Agile or Kanban.

### 4.2.1. Need to know

- When we are gathering business requirements to make a user story, we need to know a few things.
- To make a successful user story, what do we need to know?
  - Well, we need to know the **role and the actor**.
    - So who is involved? i.e. a customer, a member of staff or a visitor to a website?
  - We also need to know the **conditions**, and this might be things like; that the customer should be logged in or not be registered already, or maybe viewing a certain page.
  - We also need the **action**.
    - So what does the actor need to do? Maybe they need to click a button or send an email, or perhaps even view a certain page.
  - We also need the **result**.
    - What's happens after the action? Perhaps a webpage is shown, an email is sent or a message is displayed?

## 4.3. Example user story

- Customer can buy a product on the website.
- Customer can click buy button on the website.
- Customer clicks buy button on product page.
- Customer clicks buy button on product page and product added to shopping basket.

### 4.3.1. Questions and answers

|           | User story                                   | Gherkin |
| --------- | -------------------------------------------- | ------- |
| Who       | Customer                                     | Given   |
| Condition | On product page                              | Given   |
| Action    | Click buy button                             | When    |
| Result    | Product added to shopping to shopping basket | Then    |

## 4.4. Keywords

- `Feature`
- `Scenario`
- `Given`
- `When`
- `Then`
- `And`
- `But`
- `*`
- `Main`
- `Rule`
- `Background`
