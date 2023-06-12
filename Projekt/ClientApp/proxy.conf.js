const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:5069` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:44519';

const PROXY_CONFIG = [
  {
    context: [
      "/Sections",
   ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  },
   {
    context: [
      "/SectionField",
    ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
]

module.exports = PROXY_CONFIG;
