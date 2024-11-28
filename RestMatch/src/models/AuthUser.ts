export interface AuthUserRegistration {
  "firstName": string,
  "lastName": string,
  "nickname": string,
  "email": string,
  "password": string,
  roles: number[]
}

export interface AuthUser {
  "nickname": string,
  "password": string
}