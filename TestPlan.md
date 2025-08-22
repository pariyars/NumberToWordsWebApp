# Number to Words Web Application - Test Plan

## Test Cases

### Typical Numbers
| Input   | Expected Output                                |
|---------|-----------------------------------------------|
| 123.45  | ONE HUNDRED TWENTY THREE DOLLARS AND FORTY FIVE CENTS |
| 0.99    | NINETY NINE CENTS                              |
| 1001    | ONE THOUSAND ONE DOLLARS                   |

### Edge Cases
| Input        | Expected Output                     |
|--------------|-----------------------------------|
| 0            | ZERO DOLLARS                        |
| 1000000      | ONE MILLION DOLLARS                  |

## Verification
- Manual testing via the web UI.
- Unit testing using `NumberToWordsWebApp.Tests` project.
- Check that input numbers are correctly converted to words including dollars and cents.
