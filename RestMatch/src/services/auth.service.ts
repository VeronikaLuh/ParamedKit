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
  if (typeof window === 'undefined') return null;
  return localStorage.getItem('token');
}

const setToken = (token: string) => {
  if (typeof window === 'undefined') return null;
  localStorage.setItem('token', token);
}

const isAuth = () => {
  return !!getToken();
}

const authService = {
  login,
  signUp,
  getToken,
  setToken,
  isAuth
}

export default authService;