// jest.config.js
const { pathsToModuleNameMapper } = require('ts-jest/utils');
// In the following statement, replace `./tsconfig` with the path to your `tsconfig` file
// which contains the path mapping (ie the `compilerOptions.paths` option):
const { compilerOptions } = require('./tsconfig');

module.exports = {
  moduleNameMapper: {
    "app/(.*)": "<rootDir>/app/$1",
    "environments": "<rootDir>/environments/environment",
  },
  preset: "jest-preset-angular",
  transform: {
    "'^\".+\\.(ts|js|html)$": "ts-jest",
  },
  setupFilesAfterEnv: ["<rootDir>/setupJest.ts"],
  "transformIgnorePatterns": ["/node_modules/"]
};
