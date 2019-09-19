# Public Browse Acceptance Tests

## Introduction
The Acceptance tests are an ongoing project that will be expanded to match the public browse site as it is being developed. It utilises Selenium Grid (See [here](https://www.seleniumhq.org/docs/07_selenium_grid.jsp) for more info) to ensure driver and browser versions and types are independent of the solution.

## Environment Variables
All environment variables used in this repo are at Process level (i.e. in the same console window as the `dotnet test` command is performed).

| Variable | Example | Default |
|---------------|------------------|------------------|
| BROWSER | `chrome` | `chrome-local`<sup>1</sup> |
| PBURL | `http://publicbrowse.nhs.net` | `http://10.0.75.1:3000`<sup>2</sup> |
| HUBURL | `http://localhost:4444/wd/hub` | `http://localhost:4444/wd/hub` |

To set a process level environment variable in a CLI see the below table

| CLI | Command | Example |
|---------------|--------------------|---------------
|`bash` | `export` | `export BROWSER=chrome` |
| `cmd` | `set` | `set BROWSER=chrome`|
| `PowerShell` | `$env:` | `$env:BROWSER = "chrome"` |

<sup>1</sup> - `chrome-local` should only be used for debugging. It will use the local instance of chrome rather than the Selenium Grid nodes to run the tests

<sup>2</sup> - `10.0.75.1:3000` is the external address when running the public browse site locally, this way the nodes in the hub can connect to it without issue
