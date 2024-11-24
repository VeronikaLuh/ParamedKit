import { NextResponse } from 'next/server'
import {HttpMethods} from "@/types/enum";
import ApiService from "@/services/api.service";

export async function GET(req: Request) {
  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Restaurants`,
    method: HttpMethods.GET,
    req: req
  });

  return NextResponse.json({ message: 'Success!', data: response });
}