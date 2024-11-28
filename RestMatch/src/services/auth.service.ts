import {AuthUser, AuthUserRegistration} from "@/models/AuthUser";
import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";

const login = async (user: AuthUser) => {
  return await ApiService.makeApiRequest({
    url: '/api/auth/login',
    method: HttpMethods.POST,
    body: user
  });
}

const signUp = async (user: AuthUserRegistration) => {
  return await ApiService.makeApiRequest({
    url: '/api/auth/sign-up',
    method: HttpMethods.POST,
    body: user
  });
}

const getToken = () => {
  return localStorage.getItem('token');
}

const setToken = (token: string) => {
  localStorage.setItem('token', token);
}

const authService = {
  login,
  signUp,
  getToken,
  setToken
}

export default authService;