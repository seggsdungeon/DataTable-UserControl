# TableModuleTestApplication

The Goal of the Project is to build a highly customizable DataTable/DataGrid, which is only build with WinUi3 Components.

It is also supposed to be a good starting point to get more into UserControls in WinUi3.

# Why i think i overevaluated my skills/underestimated the difficulty of this project

I never used WinUi3 (or any other XAML based language) until 1 week(-ish) to starting this project. So i may have underestimated my new learned skills a tad bit.
I had no clue that stuff like DataTemplates and ItemRepeater exist. Glad to have encountered them now. I hope they will continue to be helpful especially with "larger" tables or other datastructures that dont need to be rendered on initial loading.

# How my Xaml is structured

So in the starting phase of my project, i thought about what my DataTable is supposed to accomplish. So i thought about a minimal version and a fully spected out version:

|Minimal|Full|
|-------|-----|
|Variable Row count|Variable Row and Column Count|
|All cells textboxes|Columns can have diffrent Inputmethods based on Inputtype|
|everything auto sizes|The Rows/Columns are customizable|
