const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/RInstatForm/allforms"
    ],
    target: "https://localhost:7238",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
