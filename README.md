# Weather Backend

## Description

This is the backend server for a weather application. It provides a simple REST API to fetch current and forecasted weather data for any city in the world. The data is sourced from the OpenWeatherMap API.

## Features

* **Current Weather:** Get real-time weather conditions for any city.
* **5-Day Forecast:** Retrieve a 5-day weather forecast with key metrics.
* **Simple & Fast:** Built with a lightweight framework for quick responses.

## Technologies Used

* **Backend:** Node.js, Express.js
* **API:** OpenWeatherMap API
* **Libraries:** Axios (for HTTP requests), dotenv (for environment variables)

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

You need to have Node.js and npm installed on your machine.
* [Node.js](https://nodejs.org/)

### Installation

1.  **Clone the repo**
    ```sh
    git clone [https://github.com/jahnavisomasundaram/WeatherBackend.git](https://github.com/jahnavisomasundaram/WeatherBackend.git)
    ```
2.  **Navigate to the project directory**
    ```sh
    cd WeatherBackend
    ```
3.  **Install NPM packages**
    ```sh
    npm install
    ```
4.  **Set up environment variables**

    Create a `.env` file in the root directory and add your OpenWeatherMap API key:

    ```
    API_KEY=your_openweathermap_api_key
    PORT=5000
    ```
5.  **Run the server**
    ```sh
    npm start
    ```

The server will be running on `http://localhost:5000`.

---

## API Endpoints

The base URL for the API is `/api`.

| Method | Endpoint             | Description                                  |
| :----- | :------------------- | :------------------------------------------- |
| `GET`  | `/weather/:city`     | Get the current weather for a specific city. |
| `GET`  | `/forecast/:city`    | Get the 5-day weather forecast for a city.   |
