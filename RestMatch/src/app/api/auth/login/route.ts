import ApiService from "@/services/api.service";
import {HttpMethods} from "@/types/enum";
import {NextResponse} from "next/server";

export async function POST(req: Request) {
  try {
    const response = await ApiService.makeHttpsRequest({
      url: `${process.env.NEXT_PUBLIC_BACKEND_URL}/Auth/login`,
      method: HttpMethods.POST,
      req: req,
    });

    return NextResponse.json({ data: response });
  } catch (error) {
    console.error('Error in API route:', error);
    return NextResponse.json({ error: 'Something went wrong' }, { status: 500 });
  }
}