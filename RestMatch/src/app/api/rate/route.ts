import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";
import {NextResponse} from "next/server";

export async function POST(req: Request) {
  const response = await ApiService.makeHttpsRequest({
    url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Rate`,
    method: HttpMethods.POST,
    req: req
  });

  return NextResponse.json({data: response});
}

