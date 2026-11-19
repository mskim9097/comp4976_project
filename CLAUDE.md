# Team rules for GradeCalc

- Do not change the existing test file `tests/GradeCalc.Tests/GradeCalculatorTests.cs`. If a test fails, fix the code in `src/`, not the test.
- Every new public method needs an XML doc comment (`/// <summary>`).
- Round final grades to 1 decimal place with `Math.Round(value, 1, MidpointRounding.AwayFromZero)`.
- Put tests for new methods in a NEW file: `tests/GradeCalc.Tests/NewFeatureTests.cs`.
- After any change, run `dotnet test` and make sure every test passes before you say you are done.
