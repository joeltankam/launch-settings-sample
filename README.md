# Sample project

This repository is a sample related to this Visual Studio problem report: [Unwanted line-break on debug command line arguments](https://developercommunity.visualstudio.com/t/Unwanted-line-break-on-debug-command-lin/10081736).

## Description

In Visual Studio 2022, adding `\n` in the command line arguments in a project debug settings will be interpreted as a new line instead of the literal value.
This is specially inconvenient when dealing with path using Windows path separator charater: `\`.

## Behavior

In this project, `Properties\lanuchSettings.json` sets `.\path\with\n\andmore` as the command line argument to debug the project:

```json
{
  "profiles": {
    "Args containing '\\n'": {
      "commandName": "Project",
      "commandLineArgs": ".\\path\\with\\n\\andmore"
    }
  }
}
```

The program only prints that value.

**Expected**:

```
.\path\with\n\andmore
```

**Actual**:

```
.\path\with
\andmore
```
