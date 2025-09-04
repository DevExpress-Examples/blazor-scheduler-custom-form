<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1304528)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Scheduler - Customize Appointment Form

This example creates custom extended and compact appointment forms for DevExpress Blazor Scheduler. In addition to standard content, custom forms display appointment time zone and have a custom layout item -- **Grade**.

Refer to the following help topic for information on how to create custom appointment forms: [Custom Appointment Forms and Tooltips](https://docs.devexpress.com/Blazor/404564/components/scheduler/customization/appointment-forms-and-tooltips#custom-appointment-form).

Like our standard appointment forms, customized forms support CRUD operations (see [Index.razor.cs](/CS/DxBlazorApplication1/Components/Pages/Index.razor.cs)). For your convinience, we created a data source that contains different appointment types (one-time, all day, and recurrent) distributed between resources. Refer to the following folders review our implementation: 

* [Models](/CS/DxBlazorApplication1/Models/) 
* [Services](/CS/DxBlazorApplication1/Services/)

![Custom Appointment Forms](./result.png)

## Files to Review

- [Index.razor](/CS/DxBlazorApplication1/Components/Pages/Index.razor)
- [Index.razor.cs](/CS/DxBlazorApplication1/Components/Pages/Index.razor.cs)

## Documentation

- [Custom Appointment Forms and Tooltips](https://docs.devexpress.com/Blazor/404564/components/scheduler/customization/appointment-forms-and-tooltips#custom-appointment-form)

## More Examples

- [Load appointments for visible interval only (lazy loading)](https://github.com/DevExpress-Examples/blazor-scheduler-load-appointments-range)
- [Implement CRUD operations with a Web API Service](https://github.com/DevExpress-Examples/blazor-scheduler-bind-to-web-api-service)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-scheduler-custom-form&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-scheduler-custom-form&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

