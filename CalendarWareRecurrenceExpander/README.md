# CalendarWare recurrence expander backend solution

## Product description

You're the co-founder and backend developer at CalendarWare, Inc, a
Roskilde-based startup specializing in next generation calendar
solutions. Among the company's innovative products are plugins for
Umbraco, Drupal, and SharePoint, adding calendars with advanced
appointment recurrence features. The recurrence expander underlying
the plugins is also to be integrated into custom project planning
software and payment systems to generate project and payment
schedules, respectively. In any event, advanced date arithmentic is
called for, including the ability to handle recurrence exceptions for
such dates as holidays and vacations.

These offerings are typically composed of a frontend and a backend
part. The frontend varies greatly with each content management,
project planning, or payment scheduling system. As luck would have it,
your co-founder is a skilled frontend developer who implements her
part using the latest fad in frontend technologies. But for the date
arithmetic, backend developer skills are required to provide the
frontend with actual dates to display.

In close cooperation, the two of you have agreed upon the requirements
for the first prototype. As you've adopted the latest and greatest in
agile development methodologies, lengthly requirement documents are a
thing of the past. Staying true to the agile spirit, you mostly work
from screenshots and improvise as you go.

While your partner develops the frontend, your job is to develop the
backend based on screenshots and below deliberately vague
requirements:

  - For the backend to be easily consumed by various frontends, it
    must be implemented using open communication standards and capable
    of receiving requests and returning responses in JSON and XML
    format. Specifically, the backend must be an ASP.NET WebAPI web
    service.

  - Focus on making the code as human-readable as possible through
    good naming of classes, methods, variables, and so forth. The code
    should also be nicely seperated into classes and method so as to
    avoid code duplication and further communication and readability.

  - Provided with a recurring appointment, the web service must expand
    the appointment into its constituent series of appointments such
    that they satisfy the recurrence pattern provided by the frontend.

  - To ensure the backend works reliably, it must be accompanied with
    automated integration tests exercising the API of the web service
    and the various recurrence expansions. Integration tests must
    accompany the web service, simulating a client calling it.

  - In developing the application, where applicable, make use of
    proper language constructs and libraries covered in the
    course. Don't try to shoehorn each and every construct into the
    application, but evaluate each against your intended design and
    pick the one you feel is right.

  - To communicate key design decisions to your partner, you must
    create and maintain a document of no more than four pages
    highlighing key design decisions such as patterns, algorithms
    used, trade-offs and an example of a web service request and
    response. Think of this document as notes to your partner and
    future self.

## Deadlines

Web service source code and documentation must be in the hands of two
potential investors no later than June 7, 2015 at 11.59pm or
CalendarWare, Inc. risks bankrupcy.

On June 16, 2015, your partner is down with the flu and you alone must
pitch your backend solution to two tech-savy potential investors. You
should prepare a presentation and time it for about 13 minutes. Make
sure to include key points from last week's documentation -- investors
are busy people so assume only one read it -- and include a demo of
the web service in action. Following your presentation, you and the
potential investors discuss your backend solution in particular and
backend topics in general.

## 

## Meta

In the spirit of today's innovation hype.

This assignments deliberately doesn't strive for be realism in all
aspects, but embraces the premise that it's a school assignment and as
such an artificial construct designed as a vihicle of measurement. Its
focus is on core backend topics, and especielly ones covered in the
course. Hence it doesn't involve a database even though most backends
require one to survive crashes and scheduled restarts. Focus is on
minimizing accidental complexity and maximizing essential complexity
and sharpening the saw in the areas covered.
  
https://www.stephencovey.com/7habits/7habits-habit7.php

Weave together to realities

Most real tasks seem daunting at first. Take a breath, think, code

Don't use third-party date manipulation library. Code it yourself.

## Requirements

To better understand the UI behavior, the screenshots below are
accompanied by examples which can also be used in testing.

### Single, non-recurring appointment

When you navigate to the calendar and select New appointment, the
following dialog box appears. The dialog enables you to create a
simple non-recurring appointment:

![Empty appointment](Empty-appointment.png)

img: New-item

The Category dropdown consisting of the following options:

  - Meeting
  - Holiday
  - Birthday
  - Anniversay

But the exact options aren't that important. Think of it as a way of
optionally tagging appointments. In the frontend, you could then
filter appointments by one of these tags.

### Daily recurring appointment

When you click the "Make this a repeating event", the dialog reacts by
expanding the user interface with a recurrence pattern selector. Also
the Start date and End date from New-item are replaced by Start time
and End time because the actual dates are generated by the recurrence
pattern:

![Repeating appointment daily](Repeating-appointment-daily.png)

Examples: 

Daily, every 3 days, starting May 1, 2015, ending after 5 occursences

5/1/2015, 5/2/2015, 5/3/2015, 5/4/2015, 5/5/2015

Daily, every weekday, starting May 1, 2015, ending after 5 occurrences

5/1/2015, 5/4/2015, 5/5/2015, 5/6/2015, 5/7/2015

## Weekly recurring appointment

![Repeating appointment weekly](Repeating-appointment-weekly.png)

Examples: 

Weekly, every 3 weeks on Mon, Wed, Fri, starting May 1, 2015, ending
after 5 occurrences 

5/1/2015, 5/18/2015, 5/20/2015, 5/22/2015, 6/8/2015


### Monthly recurring appointment

![Repeating appointment monthly](Repeating-appointment-monthly.png)

The "first" dropdown contains options: first, second, third, fourth, last
The "day" dropdown contains options: weekday, weekend day, Sunday, Monday, Turesday, Wednesday, Thursday, Friday, Saturday

Examples:

Monthly, every day 5 of every 3 months, starting May 1, 2015, ending
after 5 occurrences

5/5/2015, 8/5/2015, 11/5/2015, 2/5/2016, 5/5/2016

Monthly, third weekend day of 1 month, starting May 1, 2015, ending after 5 occurrences

5/9/2015, 6/13/2015, 7/11/2015, 8/8/2015, 9/12/2015

Monthly, last Friday of every 3 months

5/29/2015, 8/28/2015, 11/27/2015, 2/26/2016, 5/27/2016

### Yearly recurring appoinement

![Repeating appointment yearly](Repeating-appointment-yearly.png)

The first dropdown contains same options as for Monthly
The day dropdown contains same options as for Monthly
The January dropdown contains the 12 months

Examples:

Yearly, every May 5

5/5/2015, 5/5/2016, 5/5/2017, 5/5/2018, 5/5/2019

Yearly, the fourth weekday of April

4/6/2016, 4/6/2017, 4/5/2018, 4/4/2019, 4/6/2020


