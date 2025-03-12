 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44339/',
  redirectUri: baseUrl,
  clientId: 'Assignment1_App',
  responseType: 'code',
  scope: 'offline_access Assignment1',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Assignment1',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44339',
      rootNamespace: 'Assignment1',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
