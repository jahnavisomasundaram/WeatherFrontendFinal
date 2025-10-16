# Weather Forecast Frontend

## Description

This is a responsive and user-friendly frontend for the Weather Forecast application. It allows users to search for a city and view its current weather conditions and a 5-day forecast. This application is built with React and consumes the API from the [Weather Backend](https://github.com/jahnavisomasundaram/WeatherBackend).

## Features

* **City Search:** Dynamically search for any city to get weather updates.
* **Current Weather:** View detailed current weather information, including temperature, humidity, wind speed, and a weather icon.
* **5-Day Forecast:** See the weather forecast for the next five days with high/low temperatures and conditions.
* **Responsive Design:** The layout is optimized for both desktop and mobile devices.
* **Clean UI:** A modern and intuitive user interface for a seamless user experience.

## Technologies Used

* **Frontend:** React, HTML, CSS
* **API Client:** Axios (for making HTTP requests to the backend)
* **Deployment:** Vercel / Netlify / GitHub Pages (you can choose one)

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing.

### Prerequisites

You need to have Node.js and npm installed on your machine.
* [Node.js](https://nodejs.org/)

You also need to have the [Weather Backend](https://github.com/jahnavisomasundaram/WeatherBackend) server running locally.

### Installation

1.  **Clone the repo**
    ```sh
    git clone [https://github.com/jahnavisomasundaram/WeatherFrontendFinal.git](https://github.com/jahnavisomasundaram/WeatherFrontendFinal.git)
    ```
2.  **Navigate to the project directory**
    ```sh
    cd WeatherFrontendFinal
    ```
3.  **Install NPM packages**
    ```sh
    npm install
    ```
4.  **Set up environment variables**

    Create a `.env` file in the root directory and add the URL of your running backend server:

    ```
    REACT_APP_API_URL=http://localhost:5000/api
    ```
5.  **Run the application**
    ```sh
    npm start
    ```

The application will open in your browser at `http://localhost:3000`.

---

## How to Use

1.  Make sure your backend server is running.
2.  Start the frontend application using `npm start`.
3.  Type the name of a city in the search bar and press Enter.
4.  The current weather and the 5-day forecast for the searched city will be displayed.

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".

1.  Fork the Project
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4.  Push to the Branch (`git push origin feature/AmazingFeature`)
5.  Open a Pull Request

---

## License

Distributed under the MIT License. See `LICENSE` file for more information.
